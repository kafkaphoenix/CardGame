using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Cards
{
    public class CardInstance : MonoBehaviour, IClickable
    {
        public void onClick()
        {

        }

        public void onHighlight()
        {
            Vector3 scale = Vector3.one * 2;
            this.transform.localScale = scale;
        }
    }

}
