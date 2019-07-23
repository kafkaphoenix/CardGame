﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    [CreateAssetMenu(menuName = "Areas/PlayerCardsDownHolding")]
    public class PlayerDownArea : AreaLogic
    {
        public CardVariable card;
        public CardType creatureType;
        public SO.TransformVariable areaGrid;
        public GameElements.GameElementsLogic cardDownLogic;

        public override void Execute()
        {
            if (card.instance == null)
                return;

            if (card.instance.viz.card.cardType == creatureType)
            {
                card.instance.transform.SetParent(areaGrid.value.transform );
                card.instance.transform.localPosition = Vector3.zero;
                card.instance.transform.localScale = Vector3.one;
                card.instance.transform.localEulerAngles = Vector3.zero;
                card.instance.gameObject.SetActive(true);
                card.instance.currentLogic = cardDownLogic;

            }
        }
    }
}
