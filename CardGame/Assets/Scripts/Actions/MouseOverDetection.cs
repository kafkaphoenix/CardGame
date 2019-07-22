using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cards.GameStates
{
    [CreateAssetMenu(menuName = "Actions/MouseOverDetection")]
    public class MouseOverDetection : Action
    {
        private List<RaycastResult> results;

        public override void Execute(float deltaTime)
        {
            results = Settings.GetUIObjects();

            IClickable c = null;

            foreach (RaycastResult r in results)
            {
                c = r.gameObject.GetComponentInParent<IClickable>();
                if (c != null)
                {
                    c.onHighlight();
                    break;
                }
            }
            
        }
    }

}
