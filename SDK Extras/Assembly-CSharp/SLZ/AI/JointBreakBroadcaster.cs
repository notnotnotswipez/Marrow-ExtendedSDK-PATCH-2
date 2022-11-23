using UnityEngine;

namespace PuppetMasta
{
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[SerializeField]
		[HideInInspector]
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
