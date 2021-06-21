using System;
using com.rikoo.triggerable.Triggerable.Runtime.Action;
using com.rikoo.InterfaceUtilities.Runtime;
using com.rikoo.triggerable.Triggerable.Runtime.ColliderFilter;
using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Trigger
{
    public class BaseTrigger : UnityEngine.MonoBehaviour
    {
        [SerializeField] private UnityEngine.Object m_TriggerableObject;
        private ITriggerable m_TriggerableInstance;

        protected ITriggerable Triggerable => m_TriggerableInstance;
        
        [SerializeField] private UnityEngine.Object m_FilterObject;
        private IColliderFilter m_FilterInstance;

        protected IColliderFilter Filter => m_FilterInstance;

        private void Awake()
        {
            InterfaceUtilities<ITriggerable>.TryCastObjectToInstance(m_TriggerableObject, out m_TriggerableInstance);
            InterfaceUtilities<IColliderFilter>.TryCastObjectToInstance(m_FilterObject, out m_FilterInstance);
            Debug.Assert(m_TriggerableInstance != null, "Triggerable instance should not be null at this point", this);
            Debug.Assert(m_FilterInstance != null, "Filter instance should not be null at this point", this);
        }

        private void OnValidate()
        {
            if (!InterfaceUtilities<ITriggerable>.TryCastObjectToInstance(m_TriggerableObject, out m_TriggerableInstance))
            {
                if (m_TriggerableObject != null)
                {
                    Debug.LogError("Triggerable Object is invalid, it should be or contain an instance of ITriggerable");
                }
            }
            
            if (!InterfaceUtilities<IColliderFilter>.TryCastObjectToInstance(m_FilterObject, out m_FilterInstance))
            {
                if (m_FilterObject != null)
                {
                    Debug.LogError("Filter Object is invalid, it should be or contain an instance of IColliderFilter");
                }
            }
        }
    }
}