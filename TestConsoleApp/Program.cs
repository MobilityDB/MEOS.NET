using MEOS.NET.API.Internal;
using MEOS.NET.Types.Temporal;


var timezone = "UTC";
MEOSFunctions.meos_initialize(timezone);

Console.WriteLine($"Result is : {MEOSFunctions.int_bucket(12, 32, 10)}");

var tint = TemporalGeometryPoint.From("POINT(1 1)@2023-08-06 01:45:00+00:00");
Console.WriteLine(tint.ToString());

//var x = MEOSFunctions.tint_in("(10@2018-01-01 08:00:00, 20@2018-01-01 08:05:00, 15@2018-01-01 08:10:00]");

MEOSFunctions.meos_finalize();
