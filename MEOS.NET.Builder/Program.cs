using MEOS.NET.Builder.Workflow;
using MEOS.NET.Builder.View;

Display.IntroductionMessage();

var cHeaderFilePath = new RetrieveFileWorkflow()
    .RetrieveFileUntilValid(() => Display.RetrieveHeaderFileMessage());

var compiledDllFilePath = new RetrieveFileWorkflow()
    .RetrieveFileUntilValid(() => Display.RetrieveCompiledLibraryFileMessage());

var cDeclarations = new ReadFileWorkflow()
    .Run(cHeaderFilePath);

var csDeclarations = new MapDefinitionsWorkflow()
    .MapCDeclaractions(cDeclarations);

new WriteDefinitionsFileWorkflow(csDeclarations, compiledDllFilePath)
    .Write("MEOSExternalFunctions");

new WriteSafeExecutedMethodsFileWorkflow(csDeclarations)
    .Write("MEOSExposedFunctions");