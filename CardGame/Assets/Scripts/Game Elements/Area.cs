using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards.GameElements
{
    public class Area : MonoBehaviour, IDroppableArea
    {
        public AreaLogic logic;

        public void OnDrop()
        {
            logic.Execute();
        }
    }
}
