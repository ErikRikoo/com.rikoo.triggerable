using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Action
{
    public abstract class ATriggerableMonobehaviour : MonoBehaviour, ITriggerable
    {
        public abstract void OnTriggerOn();
        public abstract void OnTriggerDown();
    }
}