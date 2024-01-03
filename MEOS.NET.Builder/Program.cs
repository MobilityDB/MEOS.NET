using MEOS.NET.Builder.Workflow;
using MEOS.NET.Builder.View;

Display.IntroductionMessage();

var filePath = new RetrieveFileWorkflow()
    .RetrieveFileUntilValid();

var cDeclarations = new ReadFileWorkflow()
    .Run(filePath);

var csDeclarations = new MapDefinitionsWorkflow()
    .MapCDeclaractions(cDeclarations);

new WriteDefinitionsFileWorkflow(csDeclarations)
    .Write("output.cs");