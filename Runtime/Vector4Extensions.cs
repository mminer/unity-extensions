using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Vector4.
    /// </summary>
    public static class Vector4Extensions
    {
        /// <summary>
        /// Sets each component to its absolute value.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>Vector with absolute values.</returns>
        public static Vector4 Abs(this Vector4 vector)
        {
            return new Vector4(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z), Mathf.Abs(vector.w));
        }

        /// <summary>
        /// Sets each component to its value rounded up to the nearest integer.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>Vector with ceiling values.</returns>
        public static Vector4 Ceil(this Vector4 vector)
        {
            return new Vector4(Mathf.Ceil(vector.x), Mathf.Ceil(vector.y), Mathf.Ceil(vector.z), Mathf.Ceil(vector.w));
        }

        /// <summary>
        /// Sets each component to its value rounded down to the nearest integer.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>Vector with floored values.</returns>
        public static Vector4 Floor(this Vector4 vector)
        {
            return new Vector4(Mathf.Floor(vector.x), Mathf.Floor(vector.y), Mathf.Floor(vector.z), Mathf.Floor(vector.w));
        }

        /// <summary>
        /// Sets each component to its value rounded to the nearest integer.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>Vector with rounded values.</returns>
        public static Vector4 Round(this Vector4 vector)
        {
            return new Vector4(Mathf.Round(vector.x), Mathf.Round(vector.y), Mathf.Round(vector.z), Mathf.Round(vector.w));
        }

        /// <summary>
        /// Sets the x component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="x">New value for x.</param>
        /// <returns>Updated vector.</returns>
        public static Vector4 WithX(this Vector4 vector, float x)
        {
            return new Vector4(x, vector.y, vector.z, vector.w);
        }

        /// <summary>
        /// Sets the y component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="y">New value for y.</param>
        /// <returns>Updated vector.</returns>
        public static Vector4 WithY(this Vector4 vector, float y)
        {
            return new Vector4(vector.x, y, vector.z, vector.w);
        }

        /// <summary>
        /// Sets the z component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="z">New value for z.</param>
        /// <returns>Updated vector.</returns>
        public static Vector4 WithZ(this Vector4 vector, float z)
        {
            return new Vector4(vector.x, vector.y, z, vector.w);
        }

        /// <summary>
        /// Sets the w component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="w">New value for w.</param>
        /// <returns>Updated vector.</returns>
        public static Vector4 WithW(this Vector4 vector, float w)
        {
            return new Vector4(vector.x, vector.y, vector.z, w);
        }
    }
}
