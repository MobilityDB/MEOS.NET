using ExampleApp;
using ExampleApp.Samples;

using MEOS.NET.Exceptions;
using MEOS.NET.Lifecycle;

var timezone = "UTC";
MEOSLifecycle.Initialize(timezone);

var samples = new List<ISample>
{
    //new BasicUsageSample(),
    new StockMarketSample(cryptoSlug: "bitcoin", secondsInterval: 30, repetitions: 8),
};

try
{
    foreach (var sample in samples)
    {
        sample.Run();
    }
}
catch (MEOSException e)
{
    Console.WriteLine($"An error occurred in MEOS : {e.Code} - {e.Message}");
}
finally
{
    MEOSLifecycle.Terminate();
}