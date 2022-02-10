using UnityEngine;

namespace com.rikoo.InterfaceUtilities.Runtime
{
    public class InterfaceUtilities<T>
        where T : class
    {
        public static bool TryCastObjectToInstance(UnityEngine.Object _objectInstance, out T _interfaceInstance)
        {
            if (_objectInstance == null)
            {
                _interfaceInstance = null;
                return false;
            }

            if (TryCastTo(_objectInstance, out _interfaceInstance))
            {
                return true;
            }
            
            if (TryCastTo(_objectInstance, out Component component))
            {
                return TryGetInterfaceFromGO(component.gameObject, out _interfaceInstance);
            }
            
            if (TryCastTo(_objectInstance, out GameObject go))
            {
                return TryGetInterfaceFromGO(go, out _interfaceInstance);
            }

            return false;
        }
        
        public static bool TryCastTo<T>(UnityEngine.Object instance, out T ret)
            where T : class
        {
            ret = instance as T;
            return ret != null;
        }
        
        public static bool TryGetInterfaceFromGO(GameObject go, out T _interfaceInstance)
        {
            _interfaceInstance = go.GetComponent<T>();
            return _interfaceInstance != null;
        }
    }
}