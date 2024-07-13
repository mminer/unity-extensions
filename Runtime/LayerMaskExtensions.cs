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
        /// <param name="layers">Names of layers to add.</param>
        /// <returns>Updated layer mask.</returns>
        public static LayerMask WithLayers(this LayerMask layerMask, params string[] layerNames)
        {
            var layers = GetLayersFromLayerNames(layerNames);
            return layerMask.WithLayers(layers);
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
        /// <param name="layers">Names of layers to remove.</param>
        /// <returns>Updated layer mask.</returns>
        public static LayerMask WithoutLayers(this LayerMask layerMask, params string[] layerNames)
        {
            var layers = GetLayersFromLayerNames(layerNames);
            return layerMask.WithoutLayers(layers);
        }

        static int[] GetLayersFromLayerNames(string[] layerNames)
        {
            var layers = new int[layerNames.Length];

            for (var i = 0; i < layerNames.Length; i++)
            {
                layers[i] = LayerMask.NameToLayer(layerNames[i]);
            }

            return layers;
        }
    }
}
