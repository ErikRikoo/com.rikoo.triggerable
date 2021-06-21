using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Action.Logging
{
    public class LoggingTriggerableMB : ATriggerableMonobehaviour
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