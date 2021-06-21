using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Action.AnimatorTriggerable
{
    public class IntegerAnimatorTriggerable : AAnimatorTriggerable
    {
        [SerializeField] private int m_OnTriggerValue;
        [SerializeField] private int m_DownTriggerValue;

        public override void OnTriggerOn()
        {
            SetAnimatorValue(m_OnTriggerValue);
        }

        public override void OnTriggerDown()
        {
            SetAnimatorValue(m_DownTriggerValue);
        }

        private void SetAnimatorValue(int _newValue)
        {
            m_Animator.SetInteger(m_ParameterHash, _newValue);
        }

        protected override AnimatorControllerParameterType AnimatorParameterType =>
            AnimatorControllerParameterType.Int;
    }
}