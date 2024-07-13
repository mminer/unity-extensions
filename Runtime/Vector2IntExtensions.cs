using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Vector2Int.
    /// </summary>
    public static class Vector2IntExtensions
    {
        /// <summary>
        /// Sets the x component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="x">New value for x.</param>
        /// <returns>Updated vector.</returns>
        public static Vector2Int WithX(this Vector2Int vector, int x)
        {
            return new Vector2Int(x, vector.y);
        }

        /// <summary>
        /// Sets the y component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="y">New value for y.</param>
        /// <returns>Updated vector.</returns>
        public static Vector2Int WithY(this Vector2Int vector, int y)
        {
            return new Vector2Int(vector.x, y);
        }
    }
}
