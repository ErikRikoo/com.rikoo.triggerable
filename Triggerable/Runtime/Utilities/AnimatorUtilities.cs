using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Utilities
{
    public static class AnimatorUtilities
    {
        public static bool HasParameter(
            this Animator _instance, 
            string _parameterName, AnimatorControllerParameterType _parameterType)
        {
            int parameterHash = Animator.StringToHash(_parameterName);
            foreach (var parameter in _instance.parameters)
            {
                if (parameter.nameHash == parameterHash && parameter.type == _parameterType)
                {
                    return true;
                }
            }

            return false;
        }
    }
}