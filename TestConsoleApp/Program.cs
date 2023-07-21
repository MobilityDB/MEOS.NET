using MEOS.NET.Types.Temporal;
using Npgsql;


var connectionString = "Host=localhost;Port=5432;Database=test;Username=postgres;Password=admin";
var table = "testable";
var column = "custom";
//var connectionString = "Host=20.79.254.53;Port=5432;Database=opensky;Username=mobilitydb-guest;Password=mobilitydb@guest";
//var table = "flight_traj";
//var column = "squawk";

var datasourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
//datasourceBuilder.MapComposite<TemporalInt>("tint");
datasourceBuilder.MapComposite<CustomType>("custom_type");

using var dataSource = datasourceBuilder.Build();

var connection = dataSource.OpenConnection();

try
{
    var query = $"SELECT {column} FROM {table} LIMIT 100";

    using (var command = new NpgsqlCommand(query, connection))
    {
        var pm = new NpgsqlParameter();

        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                //var data = reader.GetFieldValue<TemporalInt>(0);
                var data = reader.GetFieldValue<CustomType>(0);
                Console.WriteLine(data);
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    connection.Close();
}

public class CustomType
{
    public int Field1 { get; set; }
    public string Field2 { get; set; }

    public override string ToString()
    {
        return $"{Field1} : {Field2}";
    }
}