using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.ColliderFilter
{
    public interface IColliderFilter
    {
        bool IsColliderValid(Collider other);
    }
}