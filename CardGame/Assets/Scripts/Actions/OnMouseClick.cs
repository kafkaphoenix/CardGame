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
                List<RaycastResult> results = Settings.GetUIObjects();

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
