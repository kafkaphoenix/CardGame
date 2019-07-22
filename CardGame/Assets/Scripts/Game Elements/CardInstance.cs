using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Cards
{
    public class CardInstance : MonoBehaviour, IClickable
    {
        public CardViz viz;
        public Cards.GameElements.GameElementsLogic currentLogic;

        void Start()
        {
            viz = GetComponent<CardViz>();
        }

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
