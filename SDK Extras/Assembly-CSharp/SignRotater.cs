using UnityEngine;

namespace SLZ.Bonelab
{
	public class SignRotater : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody rb;

		[SerializeField]
		private float torqueForce;

		private void FixedUpdate()
		{
		}

		public SignRotater()
			: base()
		{
		}
	}
}
