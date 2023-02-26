using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[ExecuteInEditMode]
	public class StaticMask : BaseMask
	{
		[Tooltip("Only enble this option, when the mask is on a static batched game object.")]
		public bool MeshCachingEnabled;

		[HideInInspector]
		[SerializeField]
		private List<MeshTransform> meshes;

		public int CachedMeshesCount
		{
			get
			{
				return default(int);
			}
		}

		private IList<MeshTransform> Meshes
		{
			get
			{
				return null;
			}
		}

		protected void OnEnable()
		{
		}

		protected override void Start()
		{
		}

		public override void Initialize()
		{
		}

		private void LateUpdate()
		{
		}

		public StaticMask()
			: base()
		{
		}
	}
}
