using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Cards
{
    public static class Settings
    {
        public static GameManager gameManager;

        //this way can exhaust your memory with a lot of data
        private static ResourcesManager _resourcesManager;

        public static ResourcesManager GetResourcesManager()
        {
            if (_resourcesManager == null)
            {
                _resourcesManager = Resources.Load("ResourcesManager") as ResourcesManager;
            }

            return _resourcesManager;
        }

        public static List<RaycastResult> GetUIObjects()
        {
            // Press mouse button
            PointerEventData pointerData = new PointerEventData(EventSystem.current)
            {
                position = Input.mousePosition
            };

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);
            return results;
        }
    }
}
