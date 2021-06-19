using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Trigger
{
    public class MinimumCountTrigger : ATriggerCounter
    {
        [SerializeField] private int m_MinimumCount;
        
        protected override void OnCountChanged(int newCount, int delta)
        {
            if (delta > 0 && newCount >= m_MinimumCount)
            {
                Triggerable.OnTriggerOn();
            } else if (delta < 0 && newCount < m_MinimumCount)
            {
                Triggerable.OnTriggerDown();
            } 
        }
    }
}