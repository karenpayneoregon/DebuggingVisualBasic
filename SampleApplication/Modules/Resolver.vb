Imports System.IO
Imports System.Reflection

Namespace Modules
    Module Resolver
        ''' <summary>
        ''' This handler is called only when the common language runtime tries to bind to the assembly and fails.        
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="args"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function ResolveEventHandler(sender As Object, args As ResolveEventArgs) As Assembly

            Dim executingAssemblies As Assembly = Assembly.GetExecutingAssembly()
            Dim referencedAssembliesNames() As AssemblyName = executingAssemblies.GetReferencedAssemblies()
            Dim assemblyName As AssemblyName
            Dim dllAssembly As Assembly = Nothing

            For Each assemblyName In referencedAssembliesNames

                'Look for the assembly names that have raised the "AssemblyResolve" event.
                If (assemblyName.FullName.Substring(0, assemblyName.FullName.IndexOf(",", StringComparison.Ordinal)) = args.Name.Substring(0, args.Name.IndexOf(",", StringComparison.Ordinal))) Then

                    ' Build path to place DLL
                    Dim tempAssemblyPath As String = Path.Combine(My.Application.DllFolder, args.Name.Substring(0, args.Name.IndexOf(",", StringComparison.Ordinal)) & ".dll")
                    dllAssembly = Assembly.LoadFrom(tempAssemblyPath)

                    Exit For

                End If
            Next

            Return dllAssembly

        End Function
    End Module
End Namespace