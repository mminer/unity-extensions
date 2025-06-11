using System.Collections.Generic;
using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Vector2.
    /// </summary>
    public static class Vector2Extensions
    {
        /// <summary>
        /// Sets each component to its absolute value.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>Vector with absolute values.</returns>
        public static Vector2 Abs(this Vector2 vector)
        {
            return new Vector2(Mathf.Abs(vector.x), Mathf.Abs(vector.y));
        }

        /// <summary>
        /// Sets each component to its value rounded up to the nearest integer.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>Vector with ceiling values.</returns>
        public static Vector2 Ceil(this Vector2 vector)
        {
            return new Vector2(Mathf.Ceil(vector.x), Mathf.Ceil(vector.y));
        }

        /// <summary>
        /// Sets each component to its value rounded down to the nearest integer.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>Vector with floored values.</returns>
        public static Vector2 Floor(this Vector2 vector)
        {
            return new Vector2(Mathf.Floor(vector.x), Mathf.Floor(vector.y));
        }

        /// <summary>
        /// Finds the position closest to the given one.
        /// </summary>
        /// <param name="position">Position.</param>
        /// <param name="otherPositions">Other positions.</param>
        /// <returns>Closest position.</returns>
        public static Vector2 GetClosest(this Vector2 position, IEnumerable<Vector2> otherPositions)
        {
            var closest = Vector2.zero;
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
        public static Vector2 Round(this Vector2 vector)
        {
            return new Vector2(Mathf.Round(vector.x), Mathf.Round(vector.y));
        }

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
