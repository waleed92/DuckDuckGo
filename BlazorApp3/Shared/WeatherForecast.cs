namespace BlazorApp3.Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }


    public class AutoCompleteResult
    {
        public string Url { get; set; }
        public string[] Content { get; set; }

        public AutoCompleteResult()
        {

        }
        public AutoCompleteResult(string url, string[] content)
        {
            Url = url;
            Content = content;
        }
    }

    public class Results
    {
        public AutoCompleteResult autoCompleteResults;

        public Results()
        {
            autoCompleteResults = new AutoCompleteResult();
        }
    }

    public static class Data
    {
        public static string authCode = "24233d09730cc2d3a6df20f63c90119c6f8482e3";
        public static  string ServiceEndPoint = "https://rt.serpmaster.com/?q={0}&access_token={1}&scraper=google_suggest";

    }
}