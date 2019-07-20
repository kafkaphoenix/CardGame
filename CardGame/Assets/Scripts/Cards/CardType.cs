using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    public abstract class CardType : ScriptableObject
    {
        public string typeName;

        public virtual void OnSetType(CardViz viz)
        {
            Element t = Settings.getResourcesManager().typeElement;
            CardVizProperties type = viz.GetProperty(t);
            type.text.text = typeName;
        }
    }
}
