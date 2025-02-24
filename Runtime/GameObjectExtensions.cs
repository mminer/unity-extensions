using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.GameObject.
    /// </summary>
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Gets a component attached to the given game object.
        /// If one isn't found, a new one is attached and returned.
        /// </summary>
        /// <param name="gameObject">Game object.</param>
        /// <returns>Previously or newly attached component.</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            if (!gameObject.TryGetComponent<T>(out var attachedComponent))
            {
                attachedComponent = gameObject.AddComponent<T>();
            }

            return attachedComponent;
        }

        /// <summary>
        /// Checks whether a game object has a component of type T attached.
        /// </summary>
        /// <param name="gameObject">Game object.</param>
        /// <returns>True when component is attached.</returns>
        public static bool HasComponent<T>(this GameObject gameObject) where T : Component
        {
            return gameObject.TryGetComponent<T>(out _);
        }

        /// <summary>
        /// Checks if a game object's layer is part of a camera's culling mask.
        /// </summary>
        /// <param name="gameObject">Game object.</param>
        /// <param name="cullingMask">Camera's culling mask.</param>
        /// <returns>True when in the culling mask.</returns>
        public static bool IsInCullingMask(this GameObject gameObject, LayerMask cullingMask)
        {
            return (cullingMask & (1 << gameObject.layer)) != 0;
        }

        /// <summary>
        /// Equivalent to GameObject.TryGetComponent that also looks in children.
        /// </summary>
        public static bool TryGetComponentInChildren<T>(this GameObject gameObject, out T result)
        {
            result = gameObject.GetComponentInChildren<T>();
            return result is not null;
        }
    }
}
