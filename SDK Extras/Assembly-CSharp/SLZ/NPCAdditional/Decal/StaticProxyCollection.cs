using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	public class StaticProxyCollection : MonoBehaviour
	{
		public List<GameObject> Proxies;

		[SerializeField]
		[HideInInspector]
		public List<ProxyMesh> MeshProxies;

		public int GetStaticVertexCount()
		{
			return default(int);
		}

		public Mesh GetMesh(GameObject obj)
		{
			return null;
		}

		public void InitializeProxies()
		{
		}

		public static Mesh CloneMesh(Mesh mesh)
		{
			return null;
		}

		private static int GetMeshHash(Mesh clone)
		{
			return default(int);
		}

		public StaticProxyCollection()
			: base()
		{
		}
	}
}
