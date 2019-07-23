using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cards.GameStates
{
    [CreateAssetMenu(menuName = "Actions/MouseHoldWithCard")]
    public class MouseHoldWithCard : Action
    {
        public CardVariable currentCard;
        public State playerControlState;
        public SO.GameEvent onPlayerControlState;

        public override void Execute(float deltaTime)
        {
            bool mouseIsDown = Input.GetMouseButton(0);
            
            if (!mouseIsDown)
            {
                List<RaycastResult> results = Settings.GetUIObjects();

                foreach (RaycastResult r in results)
                {
                    IDroppableArea a = r.gameObject.GetComponentInParent<IDroppableArea>();
                    if (a != null)
                    {
                        a.OnDrop();
                        break;
                    }
                }

                currentCard.instance.gameObject.SetActive(true);
                currentCard.instance = null;

                Settings.gameManager.SetState(playerControlState);
                onPlayerControlState.Raise();
                return;
            }
        }
    }

}
