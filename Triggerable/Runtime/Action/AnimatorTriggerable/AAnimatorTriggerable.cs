using System;
using com.rikoo.triggerable.Triggerable.Runtime.Utilities;
using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Action.AnimatorTriggerable
{
    public abstract class AAnimatorTriggerable : ATriggerableMonobehaviour
    {
        [SerializeField] protected Animator m_Animator;
        [SerializeField] private string m_ParameterName;

        protected int m_ParameterHash;

        protected int ParameterHash => m_ParameterHash;

        private void Awake()
        {
            m_ParameterHash = Animator.StringToHash(m_ParameterName);
        }
        
        #if UNITY_EDITOR

        protected abstract AnimatorControllerParameterType AnimatorParameterType
        {
            get;
        }
        
        private void OnValidate()
        {
            if (!m_Animator.HasParameter(m_ParameterName, AnimatorParameterType))
            {
                Debug.LogError($"The animator should contain a parameter named \"{m_ParameterName}\"");
            }
        }
        
        #endif
    }
}