using UnityEngine;

namespace SLZ.Bonelab
{
	public class PhysMover : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody rb;

		[SerializeField]
		private Vector2 input;

		public void Update()
		{
		}

		public void FixedUpdate()
		{
		}

		public PhysMover()
			: base()
		{
		}
	}
}
