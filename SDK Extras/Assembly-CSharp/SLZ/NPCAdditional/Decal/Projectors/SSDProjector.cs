using System;
using ch.sycoforge.Decal.Projectors.Geometry;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors
{
	[Serializable]
	internal class SSDProjector : Projector
	{
		private static Vector3[] vertices;

		private static int[] triangles;

		internal Vector3[] normals;

		internal Vector2[] uv;

		internal Vector2[] uv2;

		internal Color[] colors;

		private bool isVisible;

		private TransformObserver transformObserver;

		private static Vector3 extents;

		public override bool IsVisible
		{
			get
			{
				return default(bool);
			}
		}

		internal override bool IsVisibleBy(RenderCamera camera)
		{
			return default(bool);
		}

		private bool InsideFrustum2(RenderCamera camera)
		{
			return default(bool);
		}

		private bool InsideFrustum(Camera camera)
		{
			return default(bool);
		}

		private void CreateStatics()
		{
		}

		private void CreateDynamics()
		{
		}

		private void CreateCubeMesh()
		{
		}

		internal override void OnGeometryPropertyChanged()
		{
		}

		internal override void Update()
		{
		}

		internal override void Project()
		{
		}

		private void InitializeProjectionCube()
		{
		}

		internal override void Dispose()
		{
		}

		internal override void DrawGizmos(bool selected)
		{
		}

		public SSDProjector(EasyDecal decal, RecreationMode mode) : base(decal, mode) { }
	}
}
