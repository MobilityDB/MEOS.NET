# MEOS.NET

__Author__: Dudziak Thomas

__My website__ : https://dudziak-thomas.be/

MEOS.NET is a .NET binding for [MEOS](https://libmeos.org), the C library underlying [MobilityDB](https://github.com/MobilityDB/MobilityDB). It exposes the MEOS spatiotemporal types and functions to managed C# code, tracking MEOS 1.4.

## What's in this solution?

- `MEOS.NET`: the binding library. Its `Internal/` layer holds the P/Invoke declarations for the MEOS C functions, generated from the [MEOS-API](https://github.com/MobilityDB/MEOS-API) catalog, and its `Types/` layer provides the hand-written, idiomatic C# wrappers over those declarations.
- `MEOS.NET.NpgSql`: integration with [Npgsql](https://www.npgsql.org/) for reading and writing MobilityDB values over a PostgreSQL connection.
- `MEOS.NET.Tests`: the unit test suite.
- `ExampleApp`: a sample application built on the binding.
- `MEOS.NET.Builder`: the original regex-based header parser. It is superseded by the IDL-driven generator under `tools/` and is kept only for historical reference.

## Prerequisites

The MEOS shared library must be installed and resolvable by the OS loader through `LD_LIBRARY_PATH` (Linux), `DYLD_LIBRARY_PATH` (macOS), or `PATH` (Windows). See the [MobilityDB](https://github.com/MobilityDB/MobilityDB) build instructions for producing the MEOS library.

## Build

From the root of the solution:

```
dotnet build
```

## Run the unit tests

```
dotnet test
```

## Run the sample application

```
cd ExampleApp
dotnet run
```

## Regenerating the bindings

The P/Invoke declarations under `MEOS.NET/Internal/` are generated from MEOS-API's `meos-idl.json` catalog rather than written by hand. To regenerate them against a given MEOS version, follow the instructions in [`tools/README.md`](tools/README.md).
