using Fluxor;
using FluxorWithBlazorServer.Data;
using Microsoft.AspNetCore.Components;

namespace FluxorWithBlazorServer.Store.Weather
{
    public class Effects
    {
        private readonly HttpClient _http;

        public Effects( HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _http.BaseAddress = new Uri(navigationManager.BaseUri);
        }

        [EffectMethod]
        public async Task HandleFetchDataAction
            (FetchDataAction action, IDispatcher dispatcher)
        {
            var forecasts = await _http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");

            if (forecasts is not null)
            {
                dispatcher.Dispatch(new FetchDataResultAction(forecasts: forecasts!));
            }
        }
    }
}
