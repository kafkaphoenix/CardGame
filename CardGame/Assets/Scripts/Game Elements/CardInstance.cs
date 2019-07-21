using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Cards
{
    public class CardInstance : MonoBehaviour, IClickable
    {
        public Cards.GameElements.GameElementsLogic currentLogic;

        public void onClick()
        {
            if (currentLogic == null)
                return;

            currentLogic.onClick(this);
        }

        public void onHighlight()
        {
            if (currentLogic == null)
                return;

            currentLogic.onHighlight(this);
        }
    }

}
