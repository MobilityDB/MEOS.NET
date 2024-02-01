using MEOS.NET.Exceptions;
using MEOS.NET.Lifecycle;
using MEOS.NET.Types.General;

var timezone = "UTC";
MEOSLifecycle.Initialize(timezone);

try
{
    var temporals = new List<TemporalGeometryPoint>()
    {
        TemporalGeometryPoint.From("[POINT(1 5)@2021-05-02, POINT(12 2)@2021-06-02]"),
        TemporalGeometryPoint.From("ePOINT(11 3)@2023-08-06 01:45:00+00:00"),
        TemporalGeometryPoint.From("[POINT(35 12)@2023-01-01, POINT(36 14)@2023-01-02]"),
    };

    var reference = TemporalGeometryPoint.From("[POINT(1 5)@2021-05-02, POINT(12 2)@2021-06-02]");

    for (int i = 0; i < temporals.Count; i++)
    {
        var text = (temporals[i] == reference) ? "equal" : "not equal";
        Console.WriteLine($"The {i + 1}th temporal element is {text} to the reference temporal");
    }

    // Sequence set with stepwise interpolation
    // var tempSeqSet = TemporalGeometryPoint.From("Interp=Step;{[POINT(1 1)@2000-01-01, POINT(2 2)@2000-01-02],[POINT(3 3)@2000-01-03, POINT(3 3)@2000-01-04]}");
    // var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "json_output.json");
    // File.WriteAllText(path, tempSeqSet.ToJson());
}
catch (MEOSException e)
{
    Console.WriteLine($"Could catch the exception : {e.Code} - {e.Message}");
}
finally
{
    MEOSLifecycle.Terminate();
}