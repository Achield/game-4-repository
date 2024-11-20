using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateManager<EState> : MonoBehaviour where EState : Enum
{
    protected Dictionary<EState, BaseState<EState>> States = new Dictionary<EState, BaseState<EState>>();

    protected BaseState<EState> CurrentState;

    protected bool isTransitionState = false;

    void Start()
    {
        CurrentState.EnterState();
    }

    private void Update()
    {
        EState nextStateKey = CurrentState.GetNextState();

        if (!isTransitionState && nextStateKey.Equals(CurrentState.StateKey))
        {
            CurrentState.UpdateState();
        }
        else
        {
            TransitionToState(nextStateKey);
        }
    }

    public void TransitionToState(EState statekey)
    {
        isTransitionState = true;
        CurrentState.ExitState();
        CurrentState = States[statekey];
        CurrentState.EnterState();
        isTransitionState = false;
    }

}
