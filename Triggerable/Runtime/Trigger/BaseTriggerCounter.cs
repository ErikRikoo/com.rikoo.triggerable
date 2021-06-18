using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Trigger
{
    public abstract class BaseTriggerCounter : BaseTrigger
    {
        protected abstract void OnCountChanged(int newCount, int delta);

        private int m_Count;
        
        private void OnTriggerEnter(Collider other)
        {
            CheckColliderAndAddDelta(other, 1);
        }

        private void OnTriggerExit(Collider other)
        {

            CheckColliderAndAddDelta(other, -1);
        }

        private void CheckColliderAndAddDelta(Collider other, int delta)
        {
            if (FilterInstance.IsColliderValid(other))
            {
                m_Count += delta;
                OnCountChanged(m_Count, delta);
            }

            if (m_Count < 0)
            {
                Debug.LogError("We have Count lower than zero, issue detected");
            }
        }
    }
}