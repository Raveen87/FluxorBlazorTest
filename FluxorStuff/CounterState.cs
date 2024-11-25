using Fluxor;

namespace FluxorBlazorTest.FluxorStuff;

[FeatureState]
public class CounterState
{
    public CounterState() { }
    
    public int ClickCount { get; }

    public CounterState(int clickCount)
    {
        ClickCount = clickCount;
    }
}
