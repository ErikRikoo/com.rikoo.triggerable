using System.Linq;
using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.ColliderFilter.Groups
{
    [CreateAssetMenu(fileName = "NoneColliderFilter", menuName = "Triggerable/Collider Filter/Groups/None", order = 0)]
    public class NoneColliderFilter : AGroupsColliderFilter
    {
        public override bool IsColliderValid(Collider collider)
        {
            return !m_Filters.Any(filter => filter.IsColliderValid(collider));
        }
    }
}