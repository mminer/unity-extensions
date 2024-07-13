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
        /// Finds the position closest to the given one.
        /// </summary>
        /// <param name="position">World position.</param>
        /// <param name="otherPositions">Other world positions.</param>
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
    }
}
