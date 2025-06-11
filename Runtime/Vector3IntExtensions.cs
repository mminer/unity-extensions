using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Vector3Int.
    /// </summary>
    public static class Vector3IntExtensions
    {
        /// <summary>
        /// Sets each component to its absolute value.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>Vector with absolute values.</returns>
        public static Vector3Int Abs(this Vector3Int vector)
        {
            return new Vector3Int(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));
        }

        /// <summary>
        /// Sets the x component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="x">New value for x.</param>
        /// <returns>Updated vector.</returns>
        public static Vector3Int WithX(this Vector3Int vector, int x)
        {
            return new Vector3Int(x, vector.y, vector.z);
        }

        /// <summary>
        /// Sets the y component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="y">New value for y.</param>
        /// <returns>Updated vector.</returns>
        public static Vector3Int WithY(this Vector3Int vector, int y)
        {
            return new Vector3Int(vector.x, y, vector.z);
        }

        /// <summary>
        /// Sets the z component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="z">New value for z.</param>
        /// <returns>Updated vector.</returns>
        public static Vector3Int WithZ(this Vector3Int vector, int z)
        {
            return new Vector3Int(vector.x, vector.y, z);
        }

        public static Vector2Int XX(this Vector3Int vector) => new(vector.x, vector.x);
        public static Vector2Int XY(this Vector3Int vector) => new(vector.x, vector.y);
        public static Vector2Int XZ(this Vector3Int vector) => new(vector.x, vector.z);
        public static Vector2Int YX(this Vector3Int vector) => new(vector.y, vector.x);
        public static Vector2Int YY(this Vector3Int vector) => new(vector.y, vector.y);
        public static Vector2Int YZ(this Vector3Int vector) => new(vector.y, vector.z);
        public static Vector2Int ZX(this Vector3Int vector) => new(vector.z, vector.x);
        public static Vector2Int ZY(this Vector3Int vector) => new(vector.z, vector.y);
        public static Vector2Int ZZ(this Vector3Int vector) => new(vector.z, vector.z);
    }
}
