using System;

namespace SLZ.SaveData
{
	public class GameLoadingEventArgs : EventArgs
	{
		public readonly SaveFlags Flags;

		public GameLoadingEventArgs(SaveFlags flags)
			: base()
		{
		}
	}
}
