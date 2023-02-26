using System.Collections.Generic;
using UnityEngine;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal
{
	public static class MeshBuffer
	{
		private const int DEFAULT_SIZE = 20;

		private static Dictionary<int, SimpleMesh> mappings;

		private static int[] ringBuffer;

		private static int bufferSize;

		private static int index;

		public static void Initialize(int size)
		{
		}

		public static void Add(Mesh mesh, int submesh)
		{
		}

		public static SimpleMesh Get(Mesh mesh, int submesh)
		{
			return null;
		}

		private static SimpleMesh Convert(Mesh mesh, int submesh)
		{
			return null;
		}
	}
}
