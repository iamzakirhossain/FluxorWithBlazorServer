using Fluxor;
using FluxorWithBlazorServer.Data;

namespace FluxorWithBlazorServer.Store.Weather
{
    [FeatureState]
    public class WeatherState
    {
        public bool IsLoading { get; }
        public IEnumerable<WeatherForecast> Forecasts { get; } = null!;

        private WeatherState() { }

        public WeatherState(bool isLoading, IEnumerable<WeatherForecast> forecasts)
        {
            IsLoading = isLoading;
            Forecasts = forecasts ?? Array.Empty<WeatherForecast>();
        }
    }
}


