using UnityEngine;

namespace ch.sycoforge.Decal
{
	public class DecalReceiver : MonoBehaviour
	{
		public int MaxDecals;

		public float DepthStep;

		internal int receivedAmount;

		internal float sum;

		internal float fractionsum;

		internal float step;

		internal EasyDecal LastDecal;

		public void Receive(EasyDecal decal)
		{
		}

		public DecalReceiver()
			: base()
		{
		}
	}
}
