using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cards.GameStates;

namespace Cards
{
    public class GameManager : MonoBehaviour
    {
        public State currentState; 

        private void Start()
        {
            Settings.gameManager = this;
        }

        private void Update()
        {
            currentState.Tick(Time.deltaTime);
        }

        public void setState(State state)
        {
            currentState = state;
        }
    }

}
