using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	public class DynamicMesh : IMesh
	{
		private const int capacity = 4048;

		protected List<Vector2> uv;

		protected List<Vector2> uv2;

		protected List<Vector3> vertices;

		protected List<Vector3> normals;

		protected List<Vector4> tangents;

		protected List<Color> vertexColors;

		internal Color[] vertexColorsFreezed;

		internal RecreationMode mode;

		private int lastVertexCount;

		internal List<int> triangleIndices;

		internal IndexTrashBin trashBin;

		protected DecalBase Parent;

		protected bool freezed;

		private bool copiedOnce;

		protected static Vector3 projectionDirection;

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

		internal RecreationMode Mode
		{
			get
			{
				return default(RecreationMode);
			}
			set
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

		internal bool Freezed
		{
			get
			{
				return default(bool);
			}
		}

		public DynamicMesh()
			: base()
		{
		}

		public DynamicMesh(DecalBase parent, RecreationMode mode)
			: this()
		{
		}

		internal void Freeze()
		{
		}

		internal void Unfreeze()
		{
		}

		internal void SetParent(EasyDecal parent)
		{
		}

		public virtual void Clear()
		{
		}

		public void Add(Mesh mesh, Matrix4x4 localToWorld)
		{
		}

		public void Add(SimpleMesh mesh, Matrix4x4 localToWorld)
		{
		}

		public void Add(Terrain terrain, Matrix4x4 localToWorld)
		{
		}

		private void Add(IList<int> triangles, IList<Vector3> vertices, IList<Vector3> normals, IList<Vector4> tangents, IList<Vector2> uvs, Matrix4x4 localToWorldMatrix)
		{
		}

		protected void AddIndices(bool det, int indexA, int indexB, int indexC)
		{
		}

		protected void AddIndices(int indexA, int indexB, int indexC)
		{
		}

		protected virtual void AddMeshData(IList<Vector3> vertices, IList<Vector3> normals, IList<Vector4> tangents, IList<Vector2> uvs, Matrix4x4 localToWorld)
		{
		}

		protected virtual void OnProcessVertexIndex(int index, bool valid)
		{
		}

		protected bool AddVertexNormal(Vector3 point, Vector3 normal)
		{
			return default(bool);
		}

		public void PostOffsetVertices()
		{
		}

		internal int[] TrianglesToArray()
		{
			return null;
		}

		public void Add(DynamicMesh dynamicMesh, Matrix4x4 sourceLocalToWorld, Matrix4x4 targetWorldToLocal)
		{
		}

		public void TransformGeometry(Matrix4x4 sourceLocalToWorld, Matrix4x4 targetWorldToLocal)
		{
		}

		public void TransformGeometry(Matrix4x4 matrix)
		{
		}

		public virtual Mesh ConvertToMesh(Mesh target, bool forceRecreation = false)
		{
			return null;
		}

		private void CopyGeometryData(Mesh mesh)
		{
		}

		internal virtual void RemoveRange(int startIndex, int count)
		{
		}

		internal void RemoveTriangleAt(int index)
		{
		}

		internal void RemoveTrianglesAt(int startIndex, int count)
		{
		}

		internal static void Assign(DynamicMesh dynMesh, Mesh mesh)
		{
		}

		protected static float Determinant(Matrix4x4 m)
		{
			return default(float);
		}
	}
}
