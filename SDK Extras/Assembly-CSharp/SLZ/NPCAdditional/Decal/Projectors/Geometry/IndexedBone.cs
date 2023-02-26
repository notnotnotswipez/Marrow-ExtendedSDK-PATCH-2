using System;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	internal class IndexedBone : IComparable<IndexedBone>
	{
		public int Index;

		public float Weight;

		public int CompareTo(IndexedBone other)
		{
			return default(int);
		}

		public IndexedBone()
			: base()
		{
		}
	}
}
