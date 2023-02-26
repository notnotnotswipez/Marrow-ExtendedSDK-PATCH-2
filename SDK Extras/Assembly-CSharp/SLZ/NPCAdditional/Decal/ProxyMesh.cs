using System;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Serializable]
	public class ProxyMesh
	{
		public int ID;

		public Mesh MeshProxy;

		public Transform transform;

		public Bounds bounds;

		public ProxyMesh()
			: base()
		{
		}
	}
}
