using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    public class CurrentSelected : MonoBehaviour
    {
        public CardVariable currentCard;
        public CardViz cardViz;
        Transform trans;

        private void Start()
        {
            trans = this.transform;
            CloseCard();
        }

        public void CloseCard()
        {
            cardViz.gameObject.SetActive(false);
        }

        public void LoadCard()
        {
            if (currentCard.instance == null)
                return;

            currentCard.instance.gameObject.SetActive(false);
            cardViz.LoadCard(currentCard.instance.viz.card);
            cardViz.gameObject.SetActive(true);
        }

        void Update()
        {
            trans.position = Input.mousePosition;
        }
    }
}

