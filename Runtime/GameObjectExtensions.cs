using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.GameObject.
    /// </summary>
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Attaches multiple components to a game object.
        /// </summary>
        /// <param name="gameObject">Game object.</param>
        public static (T1, T2) AddComponents<T1, T2>(this GameObject gameObject)
            where T1 : Component
            where T2 : Component
        {
            return (
                gameObject.AddComponent<T1>(),
                gameObject.AddComponent<T2>()
            );
        }

        /// <summary>
        /// Attaches multiple components to a game object.
        /// </summary>
        /// <param name="gameObject">Game object.</param>
        public static (T1, T2, T3) AddComponents<T1, T2, T3>(this GameObject gameObject)
            where T1 : Component
            where T2 : Component
            where T3 : Component
        {
            return (
                gameObject.AddComponent<T1>(),
                gameObject.AddComponent<T2>(),
                gameObject.AddComponent<T3>()
            );
        }

        /// <summary>
        /// Attaches multiple components to a game object.
        /// </summary>
        /// <param name="gameObject">Game object.</param>
        public static (T1, T2, T3, T4) AddComponents<T1, T2, T3, T4>(this GameObject gameObject)
            where T1 : Component
            where T2 : Component
            where T3 : Component
            where T4 : Component
        {
            return (
                gameObject.AddComponent<T1>(),
                gameObject.AddComponent<T2>(),
                gameObject.AddComponent<T3>(),
                gameObject.AddComponent<T4>()
            );
        }

        /// <summary>
        /// Attaches multiple components to a game object.
        /// </summary>
        /// <param name="gameObject">Game object.</param>
        public static (T1, T2, T3, T4, T5) AddComponents<T1, T2, T3, T4, T5>(this GameObject gameObject)
            where T1 : Component
            where T2 : Component
            where T3 : Component
            where T4 : Component
            where T5 : Component
        {
            return (
                gameObject.AddComponent<T1>(),
                gameObject.AddComponent<T2>(),
                gameObject.AddComponent<T3>(),
                gameObject.AddComponent<T4>(),
                gameObject.AddComponent<T5>()
            );
        }

        /// <summary>
        /// Attaches multiple components to a game object.
        /// </summary>
        /// <param name="gameObject">Game object.</param>
        public static (T1, T2, T3, T4, T5, T6) AddComponents<T1, T2, T3, T4, T5, T6>(this GameObject gameObject)
            where T1 : Component
            where T2 : Component
            where T3 : Component
            where T4 : Component
            where T5 : Component
            where T6 : Component
        {
            return (
                gameObject.AddComponent<T1>(),
                gameObject.AddComponent<T2>(),
                gameObject.AddComponent<T3>(),
                gameObject.AddComponent<T4>(),
                gameObject.AddComponent<T5>(),
                gameObject.AddComponent<T6>()
            );
        }

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
        /// Sets the layer of a game object and all its children.
        /// </summary>
        /// <param name="gameObject">Game object.</param>
        /// <param name="layer">Layer to apply.</param>
        public static void SetLayerInChildren(this GameObject gameObject, int layer)
        {
            foreach (var transform in gameObject.GetComponentsInChildren<Transform>(true))
            {
                transform.gameObject.layer = layer;
            }
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
