using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    [CreateAssetMenu(menuName = "Holders/Player Holder")]
    public class PlayerHolder : ScriptableObject
    {
        public string[] startingCards;
        public SO.TransformVariable handGrid;
        public SO.TransformVariable downGrid;

        public GameElements.GameElementsLogic handLogic;
        public GameElements.GameElementsLogic downLogic;

        [System.NonSerialized]
        public List<CardInstance> handCards = new List<CardInstance>();
        [System.NonSerialized]
        public List<CardInstance> cardsDown = new List<CardInstance>();
    }

}
