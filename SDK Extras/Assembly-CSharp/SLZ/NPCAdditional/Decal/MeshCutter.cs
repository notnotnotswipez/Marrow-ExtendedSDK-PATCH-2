using System.Collections.Generic;
using UnityEngine;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal
{
	public class MeshCutter<M> : IMeshCutter where M : DynamicMesh
	{
		internal const sbyte OUTSIDE = -1;

		internal const sbyte ONPLANE = 0;

		internal const sbyte INSIDE = 1;

		internal const int DEFAULT_SIZE = 1024;

		internal M dynamicMesh;

		internal EasyDecal Parent;

		internal IList<sbyte> vertexPositions;

		internal List<int> outsideIndices;

		internal List<int> trashedTriangleIndices;

		internal IndexTrashBin indexTrash;

		internal static Vector3 normalTop;

		internal static Vector3 normalBottom;

		internal static Vector3 normalRight;

		internal static Vector3 normalLeft;

		internal static Vector3 normalFront;

		internal static Vector3 normalBack;

		internal static Vector3 centerTop;

		internal static Vector3 centerBottom;

		internal static Vector3 centerRight;

		internal static Vector3 centerLeft;

		internal static Vector3 centerFront;

		internal static Vector3 centerBack;

		internal static MathPlane[] cutPlanes;

		public MeshCutter(EasyDecal parent)
			: base()
		{
		}

		void IMeshCutter.CutMesh(DynamicMesh dynamicMesh)
		{
		}

		private void Cleanup()
		{
		}

		private void RemoveIndices(IndexTrashBin trash)
		{
		}

		private void DebugPlane(Vector3 normal, Vector3 point)
		{
		}

		private bool HasIntersection(sbyte vertexPositionA, sbyte vertexPositionB)
		{
			return default(bool);
		}

		private void InitializeVertexPositions(DynamicMesh dynamicMesh, MathPlane plane)
		{
		}

		private void CutAlongPlane(DynamicMesh dynamicMesh, MathPlane plane)
		{
		}

		private void DrawRay(Ray ray, float factor)
		{
		}

		protected sbyte GetVertexPosition(MathPlane plane, Vector3 point)
		{
			return default(sbyte);
		}

		protected virtual void Cut(int indexA, int indexB, sbyte vertexPosA, MathPlane plane)
		{
		}

		protected Vector3 TransformPoint(Vector3 pointA, Vector3 pointB, float factor)
		{
			return default(Vector3);
		}

		protected Vector3 TransformPoint(Ray ray, float factor)
		{
			return default(Vector3);
		}
	}
}
