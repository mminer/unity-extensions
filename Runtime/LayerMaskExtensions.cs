using UnityEngine;

namespace UnityExtensions
{
    public static class LayerMaskExtensions
    {
        /// <summary>
        /// Adds layers to the layer mask.
        /// </summary>
        /// <param name="layerMask">Layer mask to add to.</param>
        /// <param name="layers">Layers to add.</param>
        /// <returns>Updated layer mask.</returns>
        public static LayerMask WithLayers(this LayerMask layerMask, params int[] layers)
        {
            foreach (var layer in layers)
            {
                layerMask |= 1 << layer;
            }

            return layerMask;
        }

        /// <summary>
        /// Adds layers to the layer mask.
        /// </summary>
        /// <param name="layerMask">Layer mask to add to.</param>
        /// <param name="layerNames">Names of layers to add.</param>
        /// <returns>Updated layer mask.</returns>
        public static LayerMask WithLayers(this LayerMask layerMask, params string[] layerNames)
        {
            foreach (var name in layerNames)
            {
                var layer = LayerMask.NameToLayer(name);
                layerMask |= 1 << layer;
            }

            return layerMask;
        }

        /// <summary>
        /// Removes layers from the layer mask.
        /// </summary>
        /// <param name="layerMask">Layer mask to remove from.</param>
        /// <param name="layers">Layers to remove.</param>
        /// <returns>Updated layer mask.</returns>
        public static LayerMask WithoutLayers(this LayerMask layerMask, params int[] layers)
        {
            foreach (var layer in layers)
            {
                layerMask &= ~(1 << layer);
            }

            return layerMask;
        }

        /// <summary>
        /// Removes layers from the layer mask.
        /// </summary>
        /// <param name="layerMask">Layer mask to remove from.</param>
        /// <param name="layerNames">Names of layers to remove.</param>
        /// <returns>Updated layer mask.</returns>
        public static LayerMask WithoutLayers(this LayerMask layerMask, params string[] layerNames)
        {
            foreach (var name in layerNames)
            {
                var layer = LayerMask.NameToLayer(name);
                layerMask &= ~(1 << layer);
            }

            return layerMask;
        }
    }
}
