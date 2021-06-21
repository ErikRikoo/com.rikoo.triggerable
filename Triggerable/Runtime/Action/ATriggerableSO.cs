using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Action
{
    public abstract class ATriggerableSO : ScriptableObject, ITriggerable
    {
        public abstract void OnTriggerOn();
        public abstract void OnTriggerDown();
    }
}