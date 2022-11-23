using System;

namespace SLZ.SaveData
{
	[Flags]
	public enum SaveFlags
	{
		DefaultAndPlayerSettingsAndUnlocks = 0,
		Progression = 2,
		Complete = 2
	}
}
