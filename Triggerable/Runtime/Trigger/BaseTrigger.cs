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
        private ITriggerable m_InterfaceInstance;

        protected ITriggerable InterfaceInstance => m_InterfaceInstance;
        
        [SerializeField] private UnityEngine.Object m_FilterObject;
        private IColliderFilter m_FilterInstance;

        protected IColliderFilter FilterInstance => m_FilterInstance;

        private void Awake()
        {
            InterfaceUtilities<ITriggerable>.TryCastObjectToInstance(m_TriggerableObject, out m_InterfaceInstance);
            InterfaceUtilities<IColliderFilter>.TryCastObjectToInstance(m_FilterObject, out m_FilterInstance);
        }

        private void OnValidate()
        {
            if (!InterfaceUtilities<ITriggerable>.TryCastObjectToInstance(m_TriggerableObject, out m_InterfaceInstance))
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