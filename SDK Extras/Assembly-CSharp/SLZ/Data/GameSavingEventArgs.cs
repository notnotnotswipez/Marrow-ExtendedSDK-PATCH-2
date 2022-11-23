using System;

namespace SLZ.SaveData
{
	public class GameSavingEventArgs : EventArgs
	{
		public readonly SaveFlags Flags;

		public GameSavingEventArgs(SaveFlags flags)
			: base()
		{
		}
	}
}
