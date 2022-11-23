using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Props
{
	[RequireComponent(typeof(SpawnableCratePlacer))]
	public class RadioPlacer : MonoBehaviour
	{
		[SerializeField]
		private RadioSong overrideClip;

		[SerializeField]
		private RadioStation selectedStation;

		public void SetRadioPlay(SpawnableCratePlacer scp, GameObject go)
		{
		}

		public RadioPlacer()
			: base()
		{
		}
	}
}
