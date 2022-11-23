using UnityEngine;

namespace SLZ.Bonelab
{
	public class IKTrigger : MonoBehaviour
	{
		[SerializeField]
		private bool isEnablingIK;

		private void OnTriggerEnter(Collider other)
		{
		}

		public IKTrigger()
			: base()
		{
		}
	}
}
