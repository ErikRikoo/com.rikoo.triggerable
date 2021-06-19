using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Action.Logging
{
    [CreateAssetMenu(fileName = "LoggingTriggerableSO", menuName = "Triggerable/Action/Logging", order = 0)]
    public class LoggingTriggerableSO : ATriggerableSO
    {
        [SerializeField] private string m_OnMessage = "On Trigger On";
        [SerializeField] private string m_DownMessage = "On Trigger Down";
        
        
        public override void OnTriggerOn()
        {
            Debug.Log(m_OnMessage, this);   
        }

        public override void OnTriggerDown()
        {
            Debug.Log(m_DownMessage, this);
        }
    }
}