using UnityEngine;

namespace SLZ.Bonelab
{
	public class Cable_Spawner : MonoBehaviour
	{
		[ContextMenuItem("Generate Cable", "Generate")]
		[Space(5f)]
		[Header("CABLE LIFT REF")]
		public CabletSeUp[] cableSetup;

		[Space(5f)]
		public bool isBinary;

		private float colOffset;

		public void Generate()
		{
		}

		public Cable_Spawner()
			: base()
		{
		}
	}
}
