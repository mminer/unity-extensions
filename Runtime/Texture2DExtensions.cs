using System;
using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Texture2D.
    /// </summary>
    public static class Texture2DExtensions
    {
        /// <summary>
        /// Determines whether all pixels in the texture have the same color.
        /// </summary>
        /// <param name="texture">Texture.</param>
        /// <returns>True if all pixels have the same RGBA values.</returns>
        public static bool IsSingleColor(this Texture2D texture)
        {
            var pixels = texture.GetPixels32();

            if (pixels.Length == 0)
            {
                return true;
            }

            var referencePixel = pixels[0];

            return Array.TrueForAll(pixels, pixel => pixel.r == referencePixel.r &&
                                                     pixel.g == referencePixel.g &&
                                                     pixel.b == referencePixel.b &&
                                                     pixel.a == referencePixel.a);
        }
    }
}
