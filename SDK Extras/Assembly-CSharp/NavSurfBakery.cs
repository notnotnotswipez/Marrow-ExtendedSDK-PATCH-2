using UnityEngine;
using UnityEngine.AI;

namespace SLZ.Bonelab
{
	public class NavSurfBakery : MonoBehaviour
	{
		public GameObject[] enableObjs;

		public GameObject[] disableObjs;

		private NavMeshSurface[] navMeshSurfaces;

		[ContextMenu("Bake All Navs")]
		public void BakeAllSurfaces()
		{
		}

		public NavSurfBakery()
			: base()
		{
		}
	}
}
