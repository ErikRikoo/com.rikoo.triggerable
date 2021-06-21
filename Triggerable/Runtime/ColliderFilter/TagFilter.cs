using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.ColliderFilter
{
    [CreateAssetMenu(fileName = "TagFilter", menuName = "Triggerable/Collider Filter/Tag", order = 0)]
    public class TagFilter : AColliderFilterSO
    {
        [SerializeField] private string m_TagFilter;
        
        public override bool IsColliderValid(Collider collider)
        {
            return collider.gameObject.CompareTag(m_TagFilter);
        }
    }
}