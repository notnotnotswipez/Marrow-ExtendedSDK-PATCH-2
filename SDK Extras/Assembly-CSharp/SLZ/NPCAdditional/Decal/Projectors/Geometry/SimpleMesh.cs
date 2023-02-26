using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	public class SimpleMesh : IMesh
	{
		private const int capacity = 2000;

		protected List<Vector2> uv;

		protected List<Vector2> uv2;

		protected List<Vector3> vertices;

		protected List<Vector3> normals;

		protected List<Vector4> tangents;

		protected List<Color> vertexColors;

		internal List<int> triangleIndices;

		public List<Vector3> Vertices
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<Vector3> Normals
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<Vector4> Tangents
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<Color> VertexColors
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<int> TriangleIndices
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<Vector2> UV
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<Vector2> UV2
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal int VerticesAmount
		{
			get
			{
				return default(int);
			}
		}

		internal int IndicesAmount
		{
			get
			{
				return default(int);
			}
		}

		public SimpleMesh()
			: base()
		{
		}
	}
}
