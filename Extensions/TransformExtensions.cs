using UnityEngine;

namespace Extensions
{
	/// <summary>
	/// Extension methods for UnityEngine.Transform.
	/// </summary>
	public static class TransformExtensions
	{
		/// <summary>
		/// Sets the position of a transform's children to zero.
		/// </summary>
		/// <param name="transform">Parent transform.</param>
		/// <param name="recursive">Also reset ancestor positions?</param>
		public static void ResetChildPositions (this Transform transform, bool recursive = false)
		{
			foreach (Transform child in transform) {
				child.position = Vector3.zero;

				if (recursive) {
					child.ResetChildPositions(recursive);
				}
			}
		}

		/// <summary>
		/// Sets the layer of the transform's children.
		/// </summary>
		/// <param name="transform">Parent transform.</param>
		/// <param name="layerName">Name of layer.</param>
		/// <param name="recursive">Also set ancestor layers?</param>
		public static void SetChildLayers (this Transform transform, string layerName, bool recursive = false)
		{
			var layer = LayerMask.NameToLayer(layerName);
			SetChildLayersHelper(transform, layer, recursive);
		}

		static void SetChildLayersHelper (Transform transform, int layer, bool recursive)
		{
			foreach (Transform child in transform) {
				child.gameObject.layer = layer;

				if (recursive) {
					SetChildLayersHelper(child, layer, recursive);
				}
			}
		}
	}
}
