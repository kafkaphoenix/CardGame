using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cards.GameStates
{
    [CreateAssetMenu(menuName = "Actions/OnMouseClick")]
    public class OnMouseClick : Action
    {
        public override void Execute(float deltaTime)
        {
            if (Input.GetMouseButtonDown(0))
            {
                PointerEventData pointerData = new PointerEventData(EventSystem.current)
                {
                    position = Input.mousePosition
                };

                List<RaycastResult> results = new List<RaycastResult>();
                EventSystem.current.RaycastAll(pointerData, results);

                IClickable c = null;

                foreach (RaycastResult r in results)
                {
                    c = r.gameObject.GetComponentInParent<IClickable>();
                    if (c != null)
                    {
                        c.onClick();
                        break;
                    }
                }
            }

        }
    }

}
