using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Action.AnimatorTriggerable
{
    public class BoolAnimatorTriggerable : AAnimatorTriggerable
    {
        [SerializeField] private bool m_OnTriggerValue;

        public override void OnTriggerOn()
        {
            SetAnimatorValue(m_OnTriggerValue);
        }

        public override void OnTriggerDown()
        {
            SetAnimatorValue(!m_OnTriggerValue);
        }

        private void SetAnimatorValue(bool _newValue)
        {
            m_Animator.SetBool(m_ParameterHash, _newValue);
        }

        protected override AnimatorControllerParameterType AnimatorParameterType =>
            AnimatorControllerParameterType.Bool;
    }
}