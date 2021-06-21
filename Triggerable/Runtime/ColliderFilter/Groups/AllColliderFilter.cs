using UnityEngine;
using System.Linq;
using com.rikoo.triggerable.Triggerable.Runtime.ColliderFilter;

namespace com.rikoo.triggerable.Triggerable.Runtime.ColliderFilter.Groups
{
    [CreateAssetMenu(fileName = "AllColliderFilter", menuName = "Triggerable/Collider Filter/Groups/All", order = 0)]
    public class AllColliderFilter : AGroupsColliderFilter
    {
        public override bool IsColliderValid(Collider collider)
        {
            return m_Filters.All(filter => filter.IsColliderValid(collider));
        }
    }
}