using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Transform.
    /// </summary>
    public static class TransformExtensions
    {
        /// <summary>
        /// Makes the given game objects children of the transform.
        /// </summary>
        /// <param name="transform">Parent transform.</param>
        /// <param name="children">Game objects to make children.</param>
        public static void AddChildren(this Transform transform, params GameObject[] children)
        {
            foreach (var child in children)
            {
                child.transform.parent = transform;
            }
        }

        /// <summary>
        /// Makes the game objects of given components children of the transform.
        /// </summary>
        /// <param name="transform">Parent transform.</param>
        /// <param name="children">Components of game objects to make children.</param>
        public static void AddChildren(this Transform transform, params Component[] children)
        {
            foreach (var child in children)
            {
                child.transform.parent = transform;
            }
        }

        /// <summary>
        /// Sets the position of a transform's children to zero.
        /// </summary>
        /// <param name="transform">Parent transform.</param>
        /// <param name="recursive">Also reset ancestor positions?</param>
        public static void ResetChildPositions(this Transform transform, bool recursive = false)
        {
            foreach (Transform child in transform)
            {
                child.position = Vector3.zero;

                if (recursive)
                {
                    child.ResetChildPositions(recursive);
                }
            }
        }

        /// <summary>
        /// Sets the layer of the transform's children.
        /// </summary>
        /// <param name="transform">Parent transform.</param>
        /// <param name="layerName">Name of layer.</param>
        /// <param name="recursive">Also set ancestor layers?</param>
        public static void SetChildLayers(this Transform transform, string layerName, bool recursive = false)
        {
            var layer = LayerMask.NameToLayer(layerName);
            SetChildLayersHelper(transform, layer, recursive);
        }

        static void SetChildLayersHelper(Transform transform, int layer, bool recursive)
        {
            foreach (Transform child in transform)
            {
                child.gameObject.layer = layer;

                if (recursive)
                {
                    SetChildLayersHelper(child, layer, recursive);
                }
            }
        }

        /// <summary>
        /// Sets the x component of the transform's position.
        /// </summary>
        /// <param name="transform">Transform.</param>
        /// <param name="x">New value for x.</param>
        public static void SetX(this Transform transform, float x)
        {
            var position = transform.position;
            transform.position = new Vector3(x, position.y, position.z);
        }

        /// <summary>
        /// Sets the y component of the transform's position.
        /// </summary>
        /// <param name="transform">Transform.</param>
        /// <param name="y">New value for y.</param>
        public static void SetY(this Transform transform, float y)
        {
            var position = transform.position;
            transform.position = new Vector3(position.x, y, position.z);
        }

        /// <summary>
        /// Sets the z component of the transform's position.
        /// </summary>
        /// <param name="transform">Transform.</param>
        /// <param name="z">New value for z.</param>
        public static void SetZ(this Transform transform, float z)
        {
            var position = transform.position;
            transform.position = new Vector3(position.x, position.y, z);
        }
    }
}
