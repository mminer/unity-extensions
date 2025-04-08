using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Quaternion.
    /// </summary>
    public static class QuaternionExtensions
    {
        /// <summary>
        /// Sets the X degrees of the quaternion.
        /// </summary>
        /// <param name="quaternion">Quaternion.</param>
        /// <param name="x">X euler angle.</param>
        /// <returns>Updated quaternion.</returns>
        public static Quaternion WithEulerX(this Quaternion quaternion, float x)
        {
            var eulerAngles = quaternion.eulerAngles;
            eulerAngles.x = x;
            return Quaternion.Euler(eulerAngles);
        }

        /// <summary>
        /// Sets the Y degrees of the quaternion.
        /// </summary>
        /// <param name="quaternion">Quaternion.</param>
        /// <param name="y">Y euler angle.</param>
        /// <returns>Updated quaternion.</returns>
        public static Quaternion WithEulerY(this Quaternion quaternion, float y)
        {
            var eulerAngles = quaternion.eulerAngles;
            eulerAngles.y = y;
            return Quaternion.Euler(eulerAngles);
        }

        /// <summary>
        /// Sets the Z degrees of the quaternion.
        /// </summary>
        /// <param name="quaternion">Quaternion.</param>
        /// <param name="z">Z euler angle.</param>
        /// <returns>Updated quaternion.</returns>
        public static Quaternion WithEulerZ(this Quaternion quaternion, float z)
        {
            var eulerAngles = quaternion.eulerAngles;
            eulerAngles.z = z;
            return Quaternion.Euler(eulerAngles);
        }
    }
}
