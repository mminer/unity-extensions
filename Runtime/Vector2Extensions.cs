using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Vector2.
    /// </summary>
    public static class Vector2Extensions
    {
        /// <summary>
        /// Sets the x component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="x">New value for x.</param>
        /// <returns>Updated vector.</returns>
        public static Vector2 WithX(this Vector2 vector, float x)
        {
            return new Vector2(x, vector.y);
        }

        /// <summary>
        /// Sets the y component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="y">New value for y.</param>
        /// <returns>Updated vector.</returns>
        public static Vector2 WithY(this Vector2 vector, float y)
        {
            return new Vector2(vector.x, y);
        }
    }
}
