using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards.GameStates
{
    [CreateAssetMenu(menuName = "State")]
    public class State : ScriptableObject
    {
        public Action[] actions;

        public void Tick(float deltaTime)
        {
            for (int i = 0; i < actions.Length; ++i)
            {
                actions[i].Execute(deltaTime); 
            }
        }
    }

}
