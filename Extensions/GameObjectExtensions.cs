using UnityEngine;

namespace Extensions
{
	/// <summary>
	/// Extension methods for UnityEngine.GameObject.
	/// </summary>
	public static class GameObjectExtensions
	{
		/// <summary>
		/// Gets a component attached to the given game object.
		/// If one isn't found, a new one is attached and returned.
		/// </summary>
		/// <param name="gameObject">Game object.</param>
		/// <returns>Attached component.</returns>
		public static T GetOrAddComponent<T> (this GameObject gameObject) where T : Component
		{
			var component = gameObject.GetComponent<T>() ?? gameObject.AddComponent<T>();
			return component;
		}
	}
}
