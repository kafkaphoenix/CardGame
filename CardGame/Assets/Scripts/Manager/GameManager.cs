using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cards.GameStates;

namespace Cards
{
    public class GameManager : MonoBehaviour
    {
        public State currentState; 

        private void Update()
        {
            currentState.Tick(Time.deltaTime);
        }
    }

}
