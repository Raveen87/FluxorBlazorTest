﻿using Fluxor;

namespace FluxorBlazorTest.FluxorStuff;

public static class Reducers
{
    [ReducerMethod]
    public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
        new CounterState(clickCount: state.ClickCount + 1);
}