using UnityEngine;
using System.Collections;

namespace Cards
{
    [CreateAssetMenu(menuName = "Cards/SpellCard")]
    public class SpellCard : CardType
    {
        public override void OnSetType(CardViz viz)
        {

            base.OnSetType(viz);

            viz.statsHolder.SetActive(false);
        }
    }

}
