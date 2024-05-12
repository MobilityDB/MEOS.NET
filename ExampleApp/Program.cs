using MEOS.NET.Exceptions;
using MEOS.NET.Lifecycle;
using MEOS.NET.Types.Collections;
using MEOS.NET.Types.Collections.Float;
using MEOS.NET.Types.Temporal.Number.Float;

var timezone = "UTC";
MEOSLifecycle.Initialize(timezone);

try
{

    var tfi = TemporalFloatInstant.FromString("25.0@2024-12-06");
    
    Console.WriteLine(tfi);
    Console.WriteLine(tfi.Timestamp().ToLongDateString());

    Console.WriteLine(tfi.BoundingBox().ToHexWKB());
    Console.WriteLine(tfi.BoundingBox().MaxT());

    var tf = TemporalFloatInstant.FromString("[25.0@2024-12-06, 29.0@2024-12-07]");
    var asSet = tf.ToFloatSet();
    Console.WriteLine(asSet.Count());

    foreach(var s in asSet.Values())
    {
        Console.WriteLine(s);
    }

    var tfi2 = TemporalFloatInstant.FromTimestamp(DateTime.UtcNow, 26);
    Console.WriteLine(tfi2);
    var res = tfi2.Add(28);
    Console.WriteLine(res);
    Console.WriteLine(res.IsAlwaysLessThanOrEqualTo(55));

    Console.WriteLine("===========");

    var spanSet = FloatSpanSet.FromString("{[8, 10], [11, 12]}");
    var spans = spanSet.GetSpans();
    Console.WriteLine(spans.Count());

    var bytes = spanSet.ToBytes();
    var ss2 = SpanSet.FromBytes(bytes);
    var spans2 = ss2.GetSpans();
    Console.WriteLine(spans2.Count());


    /*var temporals = new List<TemporalGeometryPoint>()
    {
        TemporalGeometryPoint.From("[POINT(1 5)@2021-05-02, POINT(12 2)@2021-06-02]"),
        TemporalGeometryPoint.From("POINT(11 3)@2023-08-06 01:45:00+00:00"),
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

    var erroneousInput = TemporalGeometryPoint.From("e[POINT(1 5)@2021-05-02, POINT(12 2)@2021-06-02]"); // Intentional input error to trigger exception*/
}
catch (MEOSException e)
{
    Console.WriteLine($"An error occurred in MEOS : {e.Code} - {e.Message}");
}
finally
{
    MEOSLifecycle.Terminate();
}