using System;
using UnityEngine;
using com.rikoo.InterfaceUtilities.Runtime;

namespace com.rikoo.triggerable.Triggerable.Runtime.Action.Multiple
{
    public class MultipleTriggerableMB : ATriggerableMonobehaviour
    {
        [SerializeField] private UnityEngine.Object[] m_ObjectInstances;
        [SerializeField] private ITriggerable[] m_TriggerableInstances;

        public override void OnTriggerOn()
        {
            foreach (var triggerable in m_TriggerableInstances)
            {
                triggerable.OnTriggerOn();
            }
        }

        public override void OnTriggerDown()
        {
            foreach (var triggerable in m_TriggerableInstances)
            {
                triggerable.OnTriggerDown();
            }
        }
        
        private void Awake()
        {
            InitTriggerables();
            for (var i = 0; i < m_ObjectInstances.Length; i++)
            {
                InterfaceUtilities<ITriggerable>.TryCastObjectToInstance(m_ObjectInstances[i], out m_TriggerableInstances[i]);
            }
        }

        private void OnValidate()
        {
            if (m_ObjectInstances == null)
            {
                return;
            }

            InitTriggerables();
            for (var i = 0; i < m_ObjectInstances.Length; i++)
            {
                if (!InterfaceUtilities<ITriggerable>.TryCastObjectToInstance(m_ObjectInstances[i],
                    out m_TriggerableInstances[i]))
                {
                    if (m_ObjectInstances[i] != null)
                    {
                        Debug.LogError($"Object at index {i} should be or contain ITriggerable", this);
                    }
                }
            }
        }

        private void InitTriggerables()
        {
            m_TriggerableInstances = new ITriggerable[m_ObjectInstances.Length];
        }
    }
}