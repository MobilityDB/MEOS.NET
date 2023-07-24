using MEOS.NET.API.Internal;

using Npgsql;

var timezone = "UTC";
MEOSFunctions.meos_initialize(timezone);

var connectionString = "...";
var table = "test";
var column = "Name";

var datasourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
//datasourceBuilder.MapComposite<TemporalInt>("tint");

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
                var data = reader.GetString(0);
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

MEOSFunctions.meos_finalize();