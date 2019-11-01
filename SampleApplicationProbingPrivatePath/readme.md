### Probing private path

This code sample demonstrates specifiing application base subdirectories for the common language runtime to search when loading assemblies. When an assembly is not found in the main application folder this path is used to find an assembly.
```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup>
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <probing privatePath="ClassLibraries" />
    </assemblyBinding>
  </runtime>
</configuration>
```

## Microsoft documentation

[&lt;probing&gt; Element](https://docs.microsoft.com/en-us/dotnet/framework/configure-apps/file-schema/runtime/probing-element)