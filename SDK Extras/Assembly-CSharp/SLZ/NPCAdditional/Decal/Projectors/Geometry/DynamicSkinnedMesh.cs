using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	public class DynamicSkinnedMesh : DynamicMesh
	{
		private SkinQuality skinQuality;

		private Transform[] bones;

		private Transform rootBone;

		private Matrix4x4[] bindPoses;

		private List<BoneWeight> bonesWeights;

		private BoneWeight[] originalBonesWeights;

		public Transform[] Bones
		{
			get
			{
				return null;
			}
		}

		public Transform RootBone
		{
			get
			{
				return null;
			}
		}

		public Matrix4x4[] BindPoses
		{
			get
			{
				return null;
			}
		}

		public List<BoneWeight> BonesWeights
		{
			get
			{
				return null;
			}
		}

		public SkinQuality SkinQuality
		{
			get
			{
				return default(SkinQuality);
			}
			set
			{
			}
		}

		internal DynamicSkinnedMesh(DecalBase parent, RecreationMode mode)
			: base()
		{
		}

		public void Add(Mesh mesh, Transform[] bones, Transform rootBone, Matrix4x4 localToWorld)
		{
		}

		internal override void RemoveRange(int startIndex, int count)
		{
		}

		protected override void OnProcessVertexIndex(int index, bool valid)
		{
		}

		public override Mesh ConvertToMesh(Mesh target, bool reset = false)
		{
			return null;
		}

		public override void Clear()
		{
		}
	}
}
