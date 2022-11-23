using System;

namespace SLZ.SaveData
{
	public class GameSavedEventArgs : EventArgs
	{
		public readonly SaveFlags Flags;

		public readonly bool CancelledOrFailed;

		public readonly Save Save;

		public GameSavedEventArgs(SaveFlags flags, bool cancelledOrFailed, Save save)
			: base()
		{
		}
	}
}
