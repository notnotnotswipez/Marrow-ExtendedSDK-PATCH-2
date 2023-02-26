using System;

namespace ch.sycoforge.Decal
{
	[Flags]
	public enum OrientationChange
	{
		None = 0,
		Rotation = 1,
		Translation = 2,
		Scale = 4
	}
}
