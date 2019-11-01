# Resolve assembly loads
This projects shows how to load an assembly in a different path outside the path for the appliation.

In the event the assembly can not be resolve a runtime exception is thrown which is caught in [WindowsFormsApplicationBase.UnhandledException Event](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.applicationservices.windowsformsapplicationbase.unhandledexception?view=netframework-4.8) and also written to a log file using a [TraceListener](https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.tracelistener?view=netframework-4.8) in a singleton class residing in a separate class project LogLibrary, [BasicListener](https://github.com/karenpayneoregon/DebuggingVisualBasic/blob/master/LogLibrary/BasicTraceListener.vb).

## Microsoft documentation
NET provides the [AppDomain.AssemblyResolve event](https://docs.microsoft.com/en-us/dotnet/api/system.appdomain.assemblyresolve?view=netframework-4.8) for applications that require greater control over assembly loading. By handling this event, your application can load an assembly into the load context from outside the normal probing paths, select which of several assembly versions to load, emit a dynamic assembly and return it, and so on. This topic provides guidance for handling the [AssemblyResolve event](https://docs.microsoft.com/en-us/dotnet/api/system.appdomain.assemblyresolve?view=netframework-4.8).

**Important**

Beginning with the .NET Framework 4, the [ResolveEventHandler event](https://docs.microsoft.com/en-us/dotnet/api/system.resolveeventhandler?view=netframework-4.8) is raised for all assemblies, including resource assemblies. In earlier versions, the event was not raised for resource assemblies. If the operating system is localized, the handler might be called multiple times: once for each culture in the fallback chain.