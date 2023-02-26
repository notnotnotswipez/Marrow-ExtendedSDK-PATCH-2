using System.Collections.Generic;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	internal sealed class IndexTrashBin
	{
		private const int INVALID = -1;

		private List<int> indices;

		private int largestValidIndex;

		private int count;

		internal void TrashIndex(int index)
		{
		}

		internal int ClampIndex(int index)
		{
			return default(int);
		}

		internal void ClearBin()
		{
		}

		internal bool Contains(int index)
		{
			return default(bool);
		}

		public IndexTrashBin()
			: base()
		{
		}
	}
}
