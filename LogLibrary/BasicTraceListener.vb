Option Infer On
Imports System.IO
Imports System.Runtime.CompilerServices

''' <summary>
''' Provide the ability to write to a log file across assemblies
''' </summary>
Public NotInheritable Class BasicTraceListener

    Private Shared ReadOnly Lazy As New Lazy(Of BasicTraceListener)(Function() New BasicTraceListener())

    Public Shared ReadOnly Property Instance() As BasicTraceListener
        Get
            Return Lazy.Value
        End Get
    End Property

    Private Shared _textWriterTraceListener As TextWriterTraceListener
    ''' <summary>
    ''' Create new instance of trace listener
    ''' </summary>
    ''' <param name="fileName">From startup project app.config file to write too</param>
    ''' <param name="listenerName">From startup project app.config unique name of listener</param>
    Public Sub CreateLog(fileName As String, listenerName As String)
        _textWriterTraceListener = New TextWriterTraceListener(fileName, listenerName)
        Trace.Listeners.Add(_textWriterTraceListener)
    End Sub
    ''' <summary>
    ''' Get file name and full path to log file
    ''' </summary>
    Public Function ListenerLogFileName() As String

        If _textWriterTraceListener Is Nothing Then
            Return ""
        End If

        Dim writer = CType(_textWriterTraceListener.Writer, StreamWriter)
        Dim stream = CType(writer.BaseStream, FileStream)

        Return stream.Name

    End Function
    ''' <summary>
    ''' Get listener name
    ''' </summary>
    ''' <returns></returns>
    Public Function ListenerName() As String
        If _textWriterTraceListener Is Nothing Then
            Return ""
        End If

        Return _textWriterTraceListener.Name
    End Function
    ''' <summary>
    ''' Write information to disk without closing
    ''' </summary>
    Public Sub Flush()
        If _textWriterTraceListener Is Nothing Then
            Return
        End If

        If WriteToTraceFile Then
            _textWriterTraceListener.Flush()
        End If

    End Sub

    ''' <summary>
    ''' Write trace information to disk
    ''' </summary>
    Public Sub Close()
        If _textWriterTraceListener Is Nothing Then
            Return
        End If

        If WriteToTraceFile Then
            _textWriterTraceListener.Flush()
            _textWriterTraceListener.Close()
        End If

    End Sub
    Public Sub Exception(message As String, <CallerMemberName> Optional ByVal callerName As String = Nothing)
        WriteEntry(message, "error", callerName)
    End Sub
    Public Sub Exception(ex As Exception, <CallerMemberName> Optional ByVal callerName As String = Nothing)
        WriteEntry(ex.Message, "error", callerName)
    End Sub
    Public Sub Warning(message As String, <CallerMemberName> Optional ByVal callerName As String = Nothing)
        WriteEntry(message, "warning", callerName)
    End Sub
    Public Sub Info(message As String, <CallerMemberName> Optional ByVal callerName As String = Nothing)
        WriteEntry(message, "info", callerName)
    End Sub
    Public Sub EmptyLine()
        _textWriterTraceListener.WriteLine("")
    End Sub
    ''' <summary>
    ''' Provides the ability to turn off logging
    ''' </summary>
    ''' <returns></returns>
    Public Property WriteToTraceFile() As Boolean
    Private Sub WriteEntry(ByVal message As String, ByVal type As String, ByVal callerName As String)
        If _textWriterTraceListener Is Nothing Then
            Return
        End If
        If Not WriteToTraceFile Then
            Return
        End If

        _textWriterTraceListener.Flush()
        _textWriterTraceListener.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss},{type},{callerName},{message}")
    End Sub
End Class