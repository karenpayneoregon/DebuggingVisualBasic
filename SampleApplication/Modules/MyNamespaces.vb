Imports System.Configuration

Namespace My
    Partial Friend Class MyApplication
        Public ReadOnly Property CustomerDllFileName() As String
            Get
                Return ConfigurationManager.AppSettings("DllName")
            End Get
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks>
        ''' </remarks>
        Public ReadOnly Property DllFolder() As String
            Get
                Return ConfigurationManager.AppSettings("DllFolder")
            End Get
        End Property

    End Class
End Namespace


