using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BasicLib
{
    public class StateMachine
    {
        public State currentState;

        public void ChangeState(State newState)
        {
            if (currentState != null)
            {
                currentState.Exit();
            }
            currentState = newState;
            currentState.Enter();
        }

        public void Update()
        {
            if (currentState != null)
            {
                currentState.FrameUpdate();
            }
        }

        private void FixedUpdate()
        {
            if (currentState != null)
            {
                currentState.PhysicsUpdate();
            }
        }
    }
}