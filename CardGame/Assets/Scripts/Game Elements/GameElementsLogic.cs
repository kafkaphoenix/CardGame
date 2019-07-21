using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards.GameElements
{
    public abstract class GameElementsLogic : ScriptableObject
    {
        public abstract void onClick(CardInstance inst);

        public abstract void onHighlight(CardInstance inst);
    }
}

