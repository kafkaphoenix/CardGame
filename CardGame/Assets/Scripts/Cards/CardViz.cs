using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Cards
{
    public class CardViz : MonoBehaviour
    {
        public Text title;
        public Text level;
        public Text cardDetail;
        public Text secondaryText;
        public Text treasures;
        public Image art;
        public Image background;
        public Image template;

        public Card card;

        private void Start()
        {
            LoadCard(card);
        }

        public void LoadCard(Card c)
        {
            if (c == null)
                return;

            card = c;
            title.text = c.title;
            art.sprite = c.art;
            cardDetail.text = c.cardDetail;
            background.sprite = c.background;
            template.sprite = c.template;

            if (string.IsNullOrEmpty(c.level))
            {
                level.gameObject.SetActive(false);
            }
            else
            {
                level.gameObject.SetActive(true);
                level.text = c.level;
            }
            if (string.IsNullOrEmpty(c.secondaryText))
            {
                secondaryText.gameObject.SetActive(false);
            } else
            {
                secondaryText.gameObject.SetActive(true);
                secondaryText.text = c.secondaryText;
            }
            if (string.IsNullOrEmpty(c.treasures))
            {
                treasures.gameObject.SetActive(false);
            }
            else
            {
                treasures.gameObject.SetActive(true);
                treasures.text = c.treasures;
            }
        }
    }
}

