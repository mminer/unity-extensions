using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Color.
    /// </summary>
    public static class ColorExtensions
    {
        /// <summary>
        /// Sets the r component of the color.
        /// </summary>
        /// <param name="color">Color.</param>
        /// <param name="r">New red value.</param>
        /// <returns>Updated color.</returns>
        public static Color WithR(this Color color, float r)
        {
            return new Color(r, color.g, color.b, color.a);
        }

        /// <summary>
        /// Sets the green component of the color.
        /// </summary>
        /// <param name="color">Color.</param>
        /// <param name="g">New green value.</param>
        /// <returns>Updated color.</returns>
        public static Color WithG(this Color color, float g)
        {
            return new Color(color.r, g, color.b, color.a);
        }

        /// <summary>
        /// Sets the blue component of the color.
        /// </summary>
        /// <param name="color">Color.</param>
        /// <param name="b">New blue value.</param>
        /// <returns>Updated color.</returns>
        public static Color WithB(this Color color, float b)
        {
            return new Color(color.r, color.g, b, color.a);
        }

        /// <summary>
        /// Sets the alpha component of the color.
        /// </summary>
        /// <param name="color">Color.</param>
        /// <param name="a">New alpha value.</param>
        /// <returns>Updated color.</returns>
        public static Color WithA(this Color color, float a)
        {
            return new Color(color.r, color.g, color.b, a);
        }
    }
}
