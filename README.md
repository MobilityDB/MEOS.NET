# MEOS.NET

__Author__: Dudziak Thomas

__My website__ : https://dudziak-thomas.be/


This is a **proof of concept** for the final MEOS.NET project.
MEOS.NET is a library that aims to wrap the functions of [MEOS](https://duckduckgo.com), the core component of [MobilityDB](https://mobilitydb.com/).

## What's in this project?

The application features :

- The MEOS.NET wrapper
- The unit tests of MEOS.NET
- An example application based on the wrapper
- An empty project that will host the code for database communication later

## Build

To build this project, clone this repository and run the following command at the root of the solution. Please note that MobilityDB should be installed before trying to run this project.

```
dotnet build
```

If an error is encountered, please remove the following lines from the MEOS.NET.csproj file and retry. This could happen if there is no meos.h file under "~/Externals/MobilityDB/meos/include/meos.h".

```
  <Target Name="BeforeBuild">
    <Exec Command="echo Building MEOS Functions..." />
    <Exec Command="python3 $(ProjectDir)API/Builder/MEOSFunctionsBuilder.py &gt; &quot;$(ProjectDir)API/Internal/MEOSFunctions.cs&quot;" />
    <Exec Command="echo MEOS Functions built successfully" />
  </Target>
```

## Run the unit tests

To run the unit tests, run the following command in the MEOS.NET.Tests folder. 

```
dotnet test
```

## Run the sample application

A sample application is provided under the ExampleApp/ folder. To run the application, please run the following command under the ExampleApp/ folder :

```
dotnet run
```



