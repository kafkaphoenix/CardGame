using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    [CreateAssetMenu(menuName = "Card")]
    public class Card : ScriptableObject
    {
        public string title;
        public string level;
        public Sprite art;
        public string cardDetail;
        public string secondaryText;
        public string treasures;
        public Sprite background;
        public Sprite template;

    }
}

