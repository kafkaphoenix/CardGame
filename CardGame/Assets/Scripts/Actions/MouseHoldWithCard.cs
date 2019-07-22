using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cards.GameStates
{
    [CreateAssetMenu(menuName = "Actions/MouseHoldWithCard")]
    public class MouseHoldWithCard : Action
    {
        public State playerControlState;
        public SO.GameEvent onPlayerControlState;

        private List<RaycastResult> results;

        public override void Execute(float deltaTime)
        {
            bool mouseIsDown = Input.GetMouseButton(0);

            if (!mouseIsDown)
            {
                results = Settings.GetUIObjects();

                foreach(RaycastResult r in results)
                {
                    //check for dropable areas
                }

                Settings.gameManager.setState(playerControlState);
                return;
            }
        }
    }

}
