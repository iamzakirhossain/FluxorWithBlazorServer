using FluxorWithBlazorServer.Data;

namespace FluxorWithBlazorServer.Store.Weather
{
    public class FetchDataResultAction
    {
        public IEnumerable<WeatherForecast> Forecasts { get; } = null!;

        public FetchDataResultAction(IEnumerable<WeatherForecast> forecasts)
        {
            Forecasts = forecasts;
        }
    }
}


