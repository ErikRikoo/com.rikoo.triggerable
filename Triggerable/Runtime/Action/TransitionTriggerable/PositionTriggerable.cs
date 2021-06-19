using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Action.TransitionTriggerable
{
    public class PositionTriggerable : ATransitionTriggerable
    {
        [SerializeField] private Vector3 m_PositionOffset;

        private Vector3 m_StartPosition;
        private Vector3 m_EndPosition;
        
        protected override void Initialize()
        {
            m_StartPosition = transform.localPosition;
            m_EndPosition = m_StartPosition + m_PositionOffset;
        }

        protected override void OnTransitionValueChanged(float _transitionValue)
        {
            transform.localPosition = Vector3.LerpUnclamped(m_StartPosition, m_EndPosition, _transitionValue);
        }
    }
}