using MEOS.NET.Exceptions;
using MEOS.NET.Functions;
using MEOS.NET.Lifecycle;
using MEOS.NET.Types;

MEOSLifecycle.Initialize("UTC");

try
{
    Console.WriteLine("Reading a temporal float instant from \"25.0@2024-12-06\"");
    Temporal tfi = TFloat.FromText("25.0@2024-12-06")!;
    Console.WriteLine($"  class            : {tfi.GetType().Name}");
    Console.WriteLine($"  text             : {tfi}");
    Console.WriteLine($"  start timestamp  : {tfi.StartTimestamptz():u}");
    Console.WriteLine($"  MF-JSON          : {tfi.AsMFJSON(0, 0, 6, string.Empty)}");
    Console.WriteLine($"  always 25.0?     : {Meos.AlwaysEqTfloatFloat(tfi.Ptr, 25.0) == 1}\n");

    Console.WriteLine("Making one from a value and a moment");
    // A MEOS timestamp holds whole microseconds and a DateTime counts ticks of
    // 100 ns, so the caller drops the ticks below a microsecond; the cast
    // refuses a moment that keeps them.
    DateTime now = DateTime.UtcNow;
    Temporal made = TFloatInst.Make(26.0, now.AddTicks(-(now.Ticks % 10)))!;
    Console.WriteLine($"  text             : {made}");
    Console.WriteLine("  adding 34 to its value");
    Temporal sum = MEOSFactory.WrapTemporal(Meos.AddTfloatFloat(made.Ptr, 34.0))!;
    Console.WriteLine($"  text             : {Meos.TemporalOut(sum.Ptr, 15)}");
    Console.WriteLine($"  always <= 30.0?  : {Meos.AlwaysLeTfloatFloat(sum.Ptr, 30.0) == 1}\n");

    Console.WriteLine("Reading a float span set from \"{[8, 10], [11, 12]}\"");
    SpanSet spanset = FloatSpanSet.FromText("{[8, 10], [11, 12]}")!;
    Console.WriteLine($"  class            : {spanset.GetType().Name}");
    Console.WriteLine($"  spans            : {spanset.NumSpans()}");
    foreach (Span? span in spanset.Spanarr())
    {
        Console.WriteLine($"    {span}");
    }

    Console.WriteLine($"  contains 9.0?    : {Meos.ContainsSpansetFloat(spanset.Ptr, 9.0)}");
    Console.WriteLine($"  width            : {((FloatSpanSet)spanset).Width(false)}\n");

    Console.WriteLine("Reading a temporal float instant from \"e25.0@2024-12-06\"");
    TFloat.FromText("e25.0@2024-12-06");
}
catch (MEOSException e)
{
    Console.WriteLine($"  MEOS reports {e.Code}: {e.Message}");
}
finally
{
    MEOSLifecycle.Terminate();
}
