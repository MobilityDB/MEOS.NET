using MEOS.NET.Exceptions;
using MEOS.NET.Lifecycle;
using MEOS.NET.Types.Collections;
using MEOS.NET.Types.Collections.Float;
using MEOS.NET.Types.Temporal.Number.Float;

var timezone = "UTC";
MEOSLifecycle.Initialize(timezone);

try
{
    Console.WriteLine("Creating temporal float instant with string : \"25.0@2024-12-06\"");
    var tfi = TemporalFloatInstant.FromString("25.0@2024-12-06");
    Console.WriteLine($"Temporal Float Instant To String : {tfi}");
    Console.WriteLine($"Temporal Float Instant Timestamp : {tfi.Timestamp().ToLongDateString()}");
    Console.WriteLine($"Temporal Float Instant HexWKB : {tfi.BoundingBox().ToHexWKB()}");
    Console.WriteLine($"Temporal Float Instant Max Time: {tfi.BoundingBox().MaxT()}");
    Console.WriteLine($"Temporal Float Instant always 25.0 ? : {tfi.IsAlwaysEqualTo(25)}\n\n");


    Console.WriteLine("Creating temporal float instant from current date (UTC), with value 26");
    var tfi2 = TemporalFloatInstant.FromTimestamp(DateTime.UtcNow, 26);
    Console.WriteLine($"Temporal Float Instant To String : {tfi2}");
    Console.WriteLine($"Temporal Float Instant Timestamp : {tfi2.Timestamp().ToLongDateString()}");
    Console.WriteLine($"Temporal Float Instant HexWKB : {tfi2.BoundingBox().ToHexWKB()}");
    Console.WriteLine($"Temporal Float Instant Max Time: {tfi2.BoundingBox().MaxT()}");
    Console.WriteLine($"Temporal Float Instant always less than 30.0 ? : {tfi2.IsAlwaysLessThanOrEqualTo(30)}");
    Console.WriteLine("Adding 34 to value of instant...");
    var tfi3 = tfi2.Add(34);
    Console.WriteLine($"Temporal Float Instant (after addition) To String : {tfi3}");
    Console.WriteLine($"Temporal Float Instant (after addition) always less than 30.0 ? : {tfi3.IsAlwaysLessThanOrEqualTo(30)}\n\n"); // Should be false since we used "Add"

    Console.WriteLine("Creating float spanset with string \"{[8, 10], [11, 12]}\"");
    var spanSet = FloatSpanSet.FromString("{[8, 10], [11, 12]}");
    Console.WriteLine("Dividing into spans...");
    var spans = spanSet.GetSpans();
    Console.WriteLine($"There are {spans.Count()} spans.");
    var bytes = spanSet.ToBytes();
    Console.WriteLine($"Bytes of the spanset : ");
    foreach (var b in bytes)
    {
        Console.Write(b + ", ");
    }
    Console.WriteLine("\n\n");

    Console.WriteLine("Creating a new float spanset2 from the bytes of the preceding one");
    var spanSetRecreated = SpanSet.FromBytes(bytes);
    Console.WriteLine($"Are the two spansets equal ? : {spanSetRecreated == spanSet}");
    Console.WriteLine("Dividing spanset2 into spans again...");
    var spans2 = spanSetRecreated.GetSpans();
    Console.WriteLine($"There are {spans2.Count()} spans in spanset2 !\n\n");

    Console.WriteLine("Trying creation of temporal float instant with erroneous string : \"e25.0@2024-12-06\"");
    TemporalFloatInstant.FromString("e25.0@2024-12-06");
}
catch (MEOSException e)
{
    Console.WriteLine($"An error occurred in MEOS : {e.Code} - {e.Message}");
}
finally
{
    MEOSLifecycle.Terminate();
}