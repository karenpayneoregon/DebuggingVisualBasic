Imports LogLibrary
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Configuration.ConfigurationManager

Namespace My
    Partial Friend Class MyApplication
        Private Property NormalShutDown() As Boolean
        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) _
            Handles Me.UnhandledException

            NormalShutDown = False

            If e.Exception.Message.Contains("Could not load") Then
                MessageBox.Show("Please run setup, press OK to close this application")
                BasicTraceListener.Instance.Exception(e.Exception.Message)
            Else
                BasicTraceListener.Instance.Exception(e.Exception.Message)
                MessageBox.Show(e.Exception.Message)
            End If

            BasicTraceListener.Instance.Exception("Shutting down abnormally")
            BasicTraceListener.Instance.Close()

        End Sub

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup

            AddHandler AppDomain.CurrentDomain.AssemblyResolve,
                AddressOf Modules.ResolveEventHandler

            NormalShutDown = True
            '
            ' Configure Listener
            '
            BasicTraceListener.Instance.CreateLog(AppSettings("AppListenerLogName"), AppSettings("AppListenerName"))
            BasicTraceListener.Instance.WriteToTraceFile = CType(AppSettings("AppListenerWriteEnabled"), Boolean)

        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            If NormalShutDown Then

                BasicTraceListener.Instance.Info("Shutting down")
                BasicTraceListener.Instance.Close()

            End If
        End Sub
    End Class
End Namespace
