using UnityEngine;
using System.Collections;

namespace Cards
{
    public static class Settings
    {
        //this way can exhaust your memory with a lot of data
        private static ResourcesManager _resourcesManager;

        public static ResourcesManager getResourcesManager()
        {
            if (_resourcesManager == null)
            {
                _resourcesManager = Resources.Load("ResourcesManager") as ResourcesManager;
            }

            return _resourcesManager;
        }
    }
}
