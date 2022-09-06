using UnityEngine;

namespace HelpersAndExtensions
{
    public static class GameObjectExtensions
    {
        public static bool TryGetComponentExtended<T>(this GameObject gameObject, out T componentToFind)
        {
            if (gameObject.TryGetComponent<T>(out var component))
            {
                componentToFind = component;
                return true;
            }
            else
            {
                componentToFind = gameObject.GetComponentInChildren<T>();
                return componentToFind != null;
            }
        }
    }
}
