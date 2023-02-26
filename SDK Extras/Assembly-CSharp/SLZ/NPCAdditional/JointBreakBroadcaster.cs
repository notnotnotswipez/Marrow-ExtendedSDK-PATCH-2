using UnityEngine;

namespace PuppetMasta
{
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[HideInInspector]
		[SerializeField]
		public PuppetMaster puppetMaster;

		[HideInInspector]
		[SerializeField]
		public int muscleIndex;

		private void OnJointBreak()
		{
		}

		public JointBreakBroadcaster()
			: base()
		{
		}
	}
}
