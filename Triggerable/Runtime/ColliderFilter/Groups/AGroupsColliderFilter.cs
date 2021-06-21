using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.ColliderFilter.Groups
{
    public abstract class AGroupsColliderFilter : AColliderFilterSO
    {
        [SerializeField] protected AColliderFilterSO[] m_Filters;

    }
}