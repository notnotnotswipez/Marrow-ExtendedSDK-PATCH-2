using UnityEngine;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal
{
	public class SkinnedMeshCutter : MeshCutter<DynamicSkinnedMesh>
	{
		private IndexedBone[] indexedBones;

		public SkinnedMeshCutter(EasyDecal parent)
			: base(parent)
		{
		}

		protected override void Cut(int indexA, int indexB, sbyte vertexPosA, MathPlane plane)
		{
		}

		private BoneWeight LerpBoneWeights(BoneWeight boneWeightA, BoneWeight boneWeightB, float stretchFactor)
		{
			return default(BoneWeight);
		}
	}
}
