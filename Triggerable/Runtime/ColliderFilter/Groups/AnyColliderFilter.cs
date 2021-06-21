using System.Linq;
using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.ColliderFilter.Groups
{
    [CreateAssetMenu(fileName = "AnyColliderFilter", menuName = "Triggerable/Collider Filter/Groups/Any", order = 0)]
    public class AnyColliderFilter : AGroupsColliderFilter
    {
        public override bool IsColliderValid(Collider collider)
        {
            return m_Filters.Any(filter => filter.IsColliderValid(collider));
        }
    }
}