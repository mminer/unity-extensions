using System;
using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Vector3Int.
    /// </summary>
    public static class Vector3IntExtensions
    {
        /// <summary>
        /// Converts a Vector3Int struct to a Vector3.
        /// </summary>
        /// <param name="vector">Vector.</param>
        /// <returns>Vector3 struct.</returns>
        public static Vector3 ToVector3(this Vector3Int vector)
        {
            return new Vector3(
                Convert.ToSingle(vector.x),
                Convert.ToSingle(vector.y),
                Convert.ToSingle(vector.z)
            );
        }
    }
}
