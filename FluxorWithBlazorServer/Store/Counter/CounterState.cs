using Fluxor;

namespace FluxorWithBlazorServer.Store.Counter
{
    [FeatureState]
    public class CounterState
    {
        public int ClickCount { get; }

        private CounterState() { }

        public CounterState(int clickCount)
        {
            ClickCount = clickCount;
        }
    }
}
