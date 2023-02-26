using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ch.sycoforge.Decal
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct DeferredFlagsComparer : IEqualityComparer<DeferredFlags>
	{
		public bool Equals(DeferredFlags x, DeferredFlags y)
		{
			return default(bool);
		}

		public int GetHashCode(DeferredFlags obj)
		{
			return default(int);
		}
	}
}
