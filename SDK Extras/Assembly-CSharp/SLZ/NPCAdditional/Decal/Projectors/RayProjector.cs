using System;
using System.Collections.Generic;
using ch.sycoforge.Decal.Projectors.Geometry;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors
{
	[Serializable]
	internal class RayProjector : Projector
	{
		private float width;

		private float length;

		internal Vector3[] sourceVertices;

		internal Vector2[] sourceUVs;

		internal int[] sourceTriangles;

		internal HashSet<int> invalidIndices;

		internal List<int> validIndices;

		private void CreateProjectionGrid()
		{
		}

		private void CreatePlaneMesh()
		{
		}

		internal override void OnGeometryPropertyChanged()
		{
		}

		internal override void Project()
		{
		}

		internal override void Dispose()
		{
		}

		internal override void DrawGizmos(bool selected)
		{
		}

		public RayProjector(EasyDecal decal, RecreationMode mode) : base(decal, mode) { }
	}
}
