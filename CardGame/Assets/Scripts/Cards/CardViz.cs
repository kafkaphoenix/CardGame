using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Cards
{
    public class CardViz : MonoBehaviour //Card Visualization
    {

        public Card card;
        public CardVizProperties[] properties;
        public Dictionary <Element, CardVizProperties> cardsProperties = new Dictionary<Element, CardVizProperties>();
        public GameObject statsHolder;

        public void LoadCard(Card c)
        {
            if (c == null)
                return;

            card = c;

            c.cardType.OnSetType(this);

            for (int i = 0; i < c.properties.Length; i++)
            {
                CardProperties cp = c.properties[i];

                CardVizProperties p = GetProperty(cp.element);

                if (p == null)
                    continue;

                if (cp.element is ElementInt)
                {
                    p.text.text = cp.intValue.ToString();
                }
                else if (cp.element is ElementText)
                {
                    p.text.text = cp.stringValue;
                }
                else if (cp.element is ElementImage)
                {
                    p.image.sprite = cp.sprite;
                }
            }
           
        }

        public CardVizProperties GetProperty(Element e)
        {
            CardVizProperties result = null;

            for (int i = 0; i < properties.Length; i++) // TODO: Dictionary
            {
                if(properties[i].element == e)
                {
                    result = properties[i];
                    break;
                }
            }

            return result;
        }
    }
}

