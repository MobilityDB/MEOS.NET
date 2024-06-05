using System.Text.Json;

using MEOS.NET.Types.Temporal.Number.Float;

namespace ExampleApp.Samples
{
    internal class StockMarketSample : ISample
    {
        private readonly string apiKey = "";

        private int repetitions;

        public string CryptoSlug { get; init; }
        public int SecondsInterval { get; init; }

        public StockMarketSample(string cryptoSlug, int secondsInterval, int repetitions)
        {
            this.CryptoSlug = cryptoSlug;
            this.SecondsInterval = secondsInterval;

            this.repetitions = repetitions;
        }

        public void Run()
        {
            List<double> values = new List<double>();
            TemporalFloatSequence? sequence = null;

            for (int i = 0; i < this.repetitions; i++)
            {
                var usdPrice = this.GetPrice();
                values.Add(usdPrice);
                
                var instant = TemporalFloatInstant.FromTimestamp(DateTime.UtcNow, usdPrice);
                Console.WriteLine($"Retrieved \"{this.CryptoSlug}\" value : {instant}");

                sequence = (sequence is null) ? instant.ToFloatSequence() : sequence.Append(instant);

                if (i < this.repetitions - 1)
                {
                    Thread.Sleep(this.SecondsInterval * 1000);
                }
            }

            // sequence = sequence.Append(TemporalFloatInstant.FromString("31000.0@2024-06-07 00:09:00+00"));
            // sequence = sequence.Append(TemporalFloatInstant.FromString("29786.01@2024-06-07 00:10:00+00"));

            Console.WriteLine();

            Console.WriteLine("Statistics using MEOS :");
            Console.WriteLine("\tTemporal duration : " + sequence!.Duration());
            Console.WriteLine("\tNumber of instants/measures : " + sequence.InstantsCount() + "\n");
            Console.WriteLine("\tIs ever less than 70500$ ? : " + sequence.IsEverLessThan(70300.0));
            Console.WriteLine("\tIs ever less than 30000$ ? : " + sequence.IsEverLessThan(30000.0));
            Console.WriteLine("\tIs always less than 100000$ ? : " + sequence.IsAlwaysLessThan(100000.0));
            Console.WriteLine("\tIs always less than 30000$ ? : " + sequence.IsAlwaysLessThan(30000.0) + "\n");
            Console.WriteLine("\tComplete sequence : " + sequence.ToString());
            Console.WriteLine("\tComplete sequence rounded : " + sequence.Round().ToString());
            Console.WriteLine("\tDistinct values : " + sequence.ToFloatSet().ToString());

            Console.Write("\tDistinct dates : " + "[");
            foreach (var e in sequence.ToDateTimeEnumerable())
            {
                Console.Write(e.ToString("s") + ", ");
            }
            Console.WriteLine("]" + "\n");

            var bbox = sequence.BoundingBox();
            Console.WriteLine("\tBounding box min time : " + bbox.MinT());
            Console.WriteLine("\tBounding box max time : " + bbox.MaxT());            
            Console.WriteLine("\tBounding box min value : " + bbox.MinX());
            Console.WriteLine("\tBounding box max value : " + bbox.MaxX());
            Console.WriteLine("\tBounding box stringified : " + bbox.ToString());
        }

        private double GetPrice()
        {
            var url = $"https://pro-api.coinmarketcap.com/v2/cryptocurrency/quotes/latest?slug={this.CryptoSlug}";
            var http = new HttpClient();
            http.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", this.apiKey);

            var result = http.GetAsync(url).Result;
            var stringifiedJson = result.Content.ReadAsStringAsync().Result;

            var jsonDoc = JsonDocument.Parse(stringifiedJson);
            var data = jsonDoc.RootElement
                .GetProperty("data");

            var usdPrice = data.EnumerateObject().First().Value
                .GetProperty("quote")
                .GetProperty("USD")
                .GetProperty("price")
                .GetDouble();

            http.Dispose();

            return usdPrice;
        }
    }
}
