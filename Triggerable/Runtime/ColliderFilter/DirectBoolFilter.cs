using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.ColliderFilter
{
    [CreateAssetMenu(fileName = "DirectBoolFilter", menuName = "Triggerable/Collider Filter/Direct Bool", order = 0)]
    public class DirectBoolFilter : AColliderFilterSO
    {
        [SerializeField] private bool m_ReturnValue;

        public override bool IsColliderValid(Collider collider)
        {
            return m_ReturnValue;
        }
    }
}