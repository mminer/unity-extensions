using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Bounds.
    /// </summary>
    public static class BoundsExtensions
    {
        /// <summary>
        /// Gets a random point inside the bounding box.
        /// </summary>
        /// <param name="bounds">Bounding box.</param>
        /// <returns>Random point within the bounds.</returns>
        public static Vector3 RandomPointInside(this Bounds bounds)
        {
            return new Vector3(
                Random.Range(bounds.min.x, bounds.max.x),
                Random.Range(bounds.min.y, bounds.max.y),
                Random.Range(bounds.min.z, bounds.max.z)
            );
        }
    }
}