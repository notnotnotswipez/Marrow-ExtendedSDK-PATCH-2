using SLZ.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Arena_TriggeredSpawners : MonoBehaviour
	{
		public ZoneSpawner[] spawners;

		private void OnDrawGizmosSelected()
		{
		}

		public Arena_TriggeredSpawners()
			: base()
		{
		}
	}
}
