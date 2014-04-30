using UnityEngine;

namespace Extensions
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
		public static void ChangeDirection (this Rigidbody rigidbody, Vector3 direction)
		{
			var newVelocity = direction * rigidbody.velocity.magnitude;
			rigidbody.velocity = newVelocity;
		}
	}
}
