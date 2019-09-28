# Serilog.Enrichers.Process

The process enricher for Serilog.
 
[![Build status](https://ci.appveyor.com/api/projects/status/ihq58voxyfwfanyg?svg=true)](https://ci.appveyor.com/project/serilog/serilog-enrichers-process) [![NuGet Version](http://img.shields.io/nuget/v/Serilog.Enrichers.Process.svg?style=flat)](https://www.nuget.org/packages/Serilog.Enrichers.Process/)


To use the enricher, first install the NuGet package:

```powershell
Install-Package Serilog.Enrichers.Process
```

Then add `Enrich.WithProcessId()` and/or `.WithProcessName()` to the `LoggerConfiguration()`:

```csharp
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .Enrich.WithProcessId()
    .Enrich.WithProcessName()
    .CreateLogger();
```

* [Documentation](https://github.com/serilog/serilog/wiki)

Copyright &copy; 2016 Serilog Contributors - Provided under the [Apache License, Version 2.0](http://apache.org/licenses/LICENSE-2.0.html).
