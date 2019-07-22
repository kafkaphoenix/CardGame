using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards.GameElements
{
    [CreateAssetMenu(menuName = "Game Elements/Card on hand")]
    public class CardsOnHand : GameElementsLogic
    {
        public SO.GameEvent onCurrentCardSelected;
        public CardVariable currentCard;
        public Cards.GameStates.State holdingCard;

        public override void onClick(CardInstance instance)
        {
            currentCard.set(instance);
            Settings.gameManager.setState(holdingCard);
            onCurrentCardSelected.Raise();
        }

        public override void onHighlight(CardInstance instance)
        {

        }
    }

}
