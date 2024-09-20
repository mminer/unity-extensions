#if USE_PHYSICS

using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Rigidbody.
    /// </summary>
    public static class RigidbodyExtensions
    {
        /// <summary>
        /// Changes the direction of a rigidbody without changing its speed.
        /// </summary>
        /// <param name="rigidbody">Rigidbody.</param>
        /// <param name="direction">New direction.</param>
        public static void ChangeDirection(this Rigidbody rigidbody, Vector3 direction)
        {
#if UNITY_6000_0_OR_NEWER
            rigidbody.linearVelocity = direction * rigidbody.linearVelocity.magnitude;
#else
            rigidbody.velocity = direction * rigidbody.velocity.magnitude;
#endif
        }
    }
}

#endif
