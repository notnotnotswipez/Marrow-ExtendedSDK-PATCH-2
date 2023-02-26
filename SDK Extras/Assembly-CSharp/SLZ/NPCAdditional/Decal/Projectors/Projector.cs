using System;
using System.Runtime.CompilerServices;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal.Projectors
{
	[Serializable]
	public abstract class Projector
	{
		protected DynamicMesh dynamicMesh;

		protected int id;

		protected EasyDecal Parent { get; set; }

		public DynamicMesh Mesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool IsVisible
		{
			get
			{
				return default(bool);
			}
		}

		internal Projector(EasyDecal decal, RecreationMode mode)
			: base()
		{
		}

		internal virtual void Reset()
		{
		}

		internal virtual bool IsVisibleBy(RenderCamera camera)
		{
			return default(bool);
		}

		internal virtual void Update()
		{
		}

		internal void UpdateVertexColor()
		{
		}

		internal virtual void OnGeometryPropertyChanged()
		{
		}

		internal virtual void OnAlphaChanged()
		{
		}

		internal virtual void OnBakeStatusChanged()
		{
		}

		internal virtual void OnFadeOutStarted()
		{
		}

		internal virtual void DrawGizmos(bool selected)
		{
		}

		internal abstract void Project();

		internal abstract void Dispose();
	}
}
