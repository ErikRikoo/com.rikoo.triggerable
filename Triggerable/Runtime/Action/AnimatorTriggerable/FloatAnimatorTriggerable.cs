using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Action.AnimatorTriggerable
{
    public class FloatAnimatorTriggerable : AAnimatorTriggerable
    {
        [SerializeField] private float m_OnTriggerValue;
        [SerializeField] private float m_DownTriggerValue;

        public override void OnTriggerOn()
        {
            SetAnimatorValue(m_OnTriggerValue);
        }

        public override void OnTriggerDown()
        {
            SetAnimatorValue(m_DownTriggerValue);
        }

        private void SetAnimatorValue(float _newValue)
        {
            m_Animator.SetFloat(m_ParameterHash, _newValue);
        }

        protected override AnimatorControllerParameterType AnimatorParameterType =>
            AnimatorControllerParameterType.Float;
    }
}