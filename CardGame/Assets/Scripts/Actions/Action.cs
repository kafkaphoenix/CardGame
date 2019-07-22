using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards.GameStates
{
    public abstract class Action : ScriptableObject
    {
        public abstract void Execute(float deltaTime);
    }

}
