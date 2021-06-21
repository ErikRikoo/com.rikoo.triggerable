using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.ColliderFilter
{
    public abstract class AColliderFilterSO : ScriptableObject, IColliderFilter
    {
        public abstract bool IsColliderValid(Collider collider);
    }
}