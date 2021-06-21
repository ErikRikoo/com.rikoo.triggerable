using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.ColliderFilter
{
    [CreateAssetMenu(fileName = "LayerFilter", menuName = "Triggerable/Collider Filter/Layer", order = 0)]
    public class LayerFilter : AColliderFilterSO
    {
        [SerializeField] private LayerMask m_LayerMaskFilter;
        
        
        public override bool IsColliderValid(Collider collider)
        {
            return ((1 << collider.gameObject.layer) & m_LayerMaskFilter) != 0;
        }
    }
}