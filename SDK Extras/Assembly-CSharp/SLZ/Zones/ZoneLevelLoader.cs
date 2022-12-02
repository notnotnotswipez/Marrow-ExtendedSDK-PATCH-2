using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Zones
{
	public class ZoneLevelLoader : ZoneItem
	{
		[Header("Dependancies")]
		public LevelCrateReference level;

		public LevelCrateReference loadScreenLevel;

		public Spawnable vfxFadeOutSpawnable;

		public UnityEvent OnLoadStart;

		public UnityEvent OnLoadEnd;

		public override void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		public void LoadLevel()
		{
		}

		public ZoneLevelLoader()
			: base()
		{
		}
	}
}
