using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Component.
    /// </summary>
    public static class ComponentExtensions
    {
        /// <summary>
        /// Attaches a component to the given component's game object.
        /// </summary>
        /// <param name="component">Component.</param>
        /// <returns>Newly attached component.</returns>
        public static T AddComponent<T>(this Component component) where T : Component
        {
            return component.gameObject.AddComponent<T>();
        }

        /// <summary>
        /// Attaches multiple components to a component's game object.
        /// </summary>
        /// <param name="component">Component.</param>
        public static (T1, T2) AddComponents<T1, T2>(this Component component)
            where T1 : Component
            where T2 : Component
        {
            return component.gameObject.AddComponents<T1, T2>();
        }

        /// <summary>
        /// Attaches multiple components to a component's game object.
        /// </summary>
        /// <param name="component">Component.</param>
        public static (T1, T2, T3) AddComponents<T1, T2, T3>(this Component component)
            where T1 : Component
            where T2 : Component
            where T3 : Component
        {
            return component.gameObject.AddComponents<T1, T2, T3>();
        }

        /// <summary>
        /// Attaches multiple components to a component's game object.
        /// </summary>
        /// <param name="component">Component.</param>
        public static (T1, T2, T3, T4) AddComponents<T1, T2, T3, T4>(this Component component)
            where T1 : Component
            where T2 : Component
            where T3 : Component
            where T4 : Component
        {
            return component.gameObject.AddComponents<T1, T2, T3, T4>();
        }

        /// <summary>
        /// Attaches multiple components to a component's game object.
        /// </summary>
        /// <param name="component">Component.</param>
        public static (T1, T2, T3, T4, T5) AddComponents<T1, T2, T3, T4, T5>(this Component component)
            where T1 : Component
            where T2 : Component
            where T3 : Component
            where T4 : Component
            where T5 : Component
        {
            return component.gameObject.AddComponents<T1, T2, T3, T4, T5>();
        }

        /// <summary>
        /// Attaches multiple components to a component's game object.
        /// </summary>
        /// <param name="component">Component.</param>
        public static (T1, T2, T3, T4, T5, T6) AddComponents<T1, T2, T3, T4, T5, T6>(this Component component)
            where T1 : Component
            where T2 : Component
            where T3 : Component
            where T4 : Component
            where T5 : Component
            where T6 : Component
        {
            return component.gameObject.AddComponents<T1, T2, T3, T4, T5, T6>();
        }

        public static T[] GetComponentsInChildrenIgnoringSelf<T>(this T component, bool includeInactive = false) where T : Component
        {
            var components = component.GetComponentsInChildren<T>(includeInactive);
            var result = new T[components.Length - 1];
            var index = 0;

            foreach (var item in components)
            {
                if (item == component)
                {
                    continue;
                }

                result[index] = item;
                index++;
            }

            return result;
        }

        /// <summary>
        /// Gets a component attached to the given component's game object.
        /// If one isn't found, a new one is attached and returned.
        /// </summary>
        /// <param name="component">Component.</param>
        /// <returns>Previously or newly attached component.</returns>
        public static T GetOrAddComponent<T>(this Component component) where T : Component
        {
            if (!component.TryGetComponent<T>(out var attachedComponent))
            {
                attachedComponent = component.AddComponent<T>();
            }

            return attachedComponent;
        }

        /// <summary>
        /// Checks whether a component's game object has a component of type T attached.
        /// </summary>
        /// <param name="component">Component.</param>
        /// <returns>True when component is attached.</returns>
        public static bool HasComponent<T>(this Component component) where T : Component
        {
            return component.TryGetComponent<T>(out _);
        }

        /// <summary>
        /// Equivalent to Component.TryGetComponent that also looks in children.
        /// </summary>
        public static bool TryGetComponentInChildren<T>(this Component component, out T result)
        {
            return component.gameObject.TryGetComponentInChildren(out result);
        }
    }
}
