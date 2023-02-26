using System.Collections.Generic;
using UnityEngine;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal
{
	public static class MeshUtil
	{
		private static List<Vector4> tangentsTemp;

		private static Mesh cubeMesh24;

		private static Vector3[] cubeVertices24;

		private static Vector3[] cubeNormals24;

		private static int[] cubeTriangles24;

		public static List<int> AdjacentIndices(IList<Vector3> vertices, IList<int> triangles, int index)
		{
			return null;
		}

		internal static IList<Vector4> CalculateTangents(IList<Vector3> vertices, IList<Vector3> normals, IList<Vector2> uv, IList<int> triangles)
		{
			return null;
		}

		internal static void CalculateNormals(IList<Vector3> normals, IList<Vector3> vertices, IList<int> triangles, float factor = 1f)
		{
		}

		internal static void SmoothVertexNormals(IList<Vector3> normals, Vector3 inverseProjectionDir, float factor, float threshold)
		{
		}

		internal static float FaceFactor(Vector3 normal, Vector3 inverseProjectionDir)
		{
			return default(float);
		}

		internal static void AutoWeld(DynamicMesh mesh, float threshold)
		{
		}

		internal static void AutoWeld(DynamicMesh mesh, float threshold, float bucketStep)
		{
		}

		internal static void TangentsMultithreaded(Mesh mesh)
		{
		}

		internal static Mesh MeshFromBoxCollider24(BoxCollider collider)
		{
			return null;
		}

		internal static Mesh MeshFromBoxCollider(BoxCollider collider)
		{
			return null;
		}

		public static bool IsNullOrDestroyed(Object obj)
		{
			return default(bool);
		}

		private static void Transform(Vector3[] vertices, Matrix4x4 m)
		{
		}

		private static void Transform(Matrix4x4[] bindPoses, Transform[] bones, Matrix4x4 m, Transform rootBone)
		{
		}

		public static Mesh Clone(Mesh sourceMesh, Matrix4x4 m)
		{
			return null;
		}

		public static Mesh Clone(Mesh sourceMesh, Matrix4x4 m, Transform[] bones, Transform root)
		{
			return null;
		}
	}
}
