using System.Collections.Generic;
using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Vector3.
    /// </summary>
    public static class Vector3Extensions
    {
        /// <summary>
        /// Sets each component to its absolute value.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>Vector with absolute values.</returns>
        public static Vector3 Abs(this Vector3 vector)
        {
            return new Vector3(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));
        }

        /// <summary>
        /// Sets each component to its value rounded up to the nearest integer.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>Vector with ceiling values.</returns>
        public static Vector3 Ceil(this Vector3 vector)
        {
            return new Vector3(Mathf.Ceil(vector.x), Mathf.Ceil(vector.y), Mathf.Ceil(vector.z));
        }

        /// <summary>
        /// Sets each component to its value rounded down to the nearest integer.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>Vector with floored values.</returns>
        public static Vector3 Floor(this Vector3 vector)
        {
            return new Vector3(Mathf.Floor(vector.x), Mathf.Floor(vector.y), Mathf.Floor(vector.z));
        }

        /// <summary>
        /// Finds the position closest to the given one.
        /// </summary>
        /// <param name="position">Position.</param>
        /// <param name="otherPositions">Other positions.</param>
        /// <returns>Closest position.</returns>
        public static Vector3 GetClosest(this Vector3 position, IEnumerable<Vector3> otherPositions)
        {
            var closest = Vector3.zero;
            var shortestDistance = Mathf.Infinity;

            foreach (var otherPosition in otherPositions)
            {
                var distance = (position - otherPosition).sqrMagnitude;

                if (distance < shortestDistance)
                {
                    closest = otherPosition;
                    shortestDistance = distance;
                }
            }

            return closest;
        }

        /// <summary>
        /// Sets each component to its value rounded to the nearest integer.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>Vector with rounded values.</returns>
        public static Vector3 Round(this Vector3 vector)
        {
            return new Vector3(Mathf.Round(vector.x), Mathf.Round(vector.y), Mathf.Round(vector.z));
        }

        /// <summary>
        /// Sets the x component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="x">New value for x.</param>
        /// <returns>Updated vector.</returns>
        public static Vector3 WithX(this Vector3 vector, float x)
        {
            return new Vector3(x, vector.y, vector.z);
        }

        /// <summary>
        /// Sets the y component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="y">New value for y.</param>
        /// <returns>Updated vector.</returns>
        public static Vector3 WithY(this Vector3 vector, float y)
        {
            return new Vector3(vector.x, y, vector.z);
        }

        /// <summary>
        /// Sets the z component of the vector.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <param name="z">New value for z.</param>
        /// <returns>Updated vector.</returns>
        public static Vector3 WithZ(this Vector3 vector, float z)
        {
            return new Vector3(vector.x, vector.y, z);
        }

        public static Vector2 XX(this Vector3 vector) => new(vector.x, vector.x);
        public static Vector2 XY(this Vector3 vector) => new(vector.x, vector.y);
        public static Vector2 XZ(this Vector3 vector) => new(vector.x, vector.z);
        public static Vector2 YX(this Vector3 vector) => new(vector.y, vector.x);
        public static Vector2 YY(this Vector3 vector) => new(vector.y, vector.y);
        public static Vector2 YZ(this Vector3 vector) => new(vector.y, vector.z);
        public static Vector2 ZX(this Vector3 vector) => new(vector.z, vector.x);
        public static Vector2 ZY(this Vector3 vector) => new(vector.z, vector.y);
        public static Vector2 ZZ(this Vector3 vector) => new(vector.z, vector.z);
    }
}
