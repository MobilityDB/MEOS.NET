# MEOS.NET Code Builder

This tool aims to help within the development of MEOS.NET.

## What is this project ?

As MEOS.NET is a wrapper for MEOS, the core component of MobilityDB, the functions of MEOS are natively called from the .NET code.

Since MEOS has a lot of features and that those features are updated regularly, we need a tool that "translates" the C declarations into C# methods declarations which can then be called from the compiled MEOS library. This subproject of the solution allows to generate the C# from the C header file of MEOS. 

**This project has, then, nothing to do with the MEOS.NET library** since it is a development tool.

## Updating MEOS

This tool is great when updating MEOS since it avoids the developer to write all the C# declarations manually. Note that if MEOS has new types, enums, this builder might need minor modifications in order to work properly.

## Usage

Run ```dotnet build``` and then ```dotnet run``` in the project. When requested, provide the path to the "meos.h". Then, the "output.cs" file will be generated with all the required code.


