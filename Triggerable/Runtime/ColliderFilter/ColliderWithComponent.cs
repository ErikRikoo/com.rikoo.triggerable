using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.ColliderFilter
{
    public class ColliderWithComponent<T> : AColliderFilterSO
    {
        public override bool IsColliderValid(Collider collider)
        {
            return collider.TryGetComponent(out T _);
        }
    }
}