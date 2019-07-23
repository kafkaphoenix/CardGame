using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    [CreateAssetMenu(menuName = "Variables/Card Variable")]
    public class CardVariable : ScriptableObject
    {
        public CardInstance instance;

        public void Set(CardInstance v)
        {
            instance = v;
        }
    }
}

