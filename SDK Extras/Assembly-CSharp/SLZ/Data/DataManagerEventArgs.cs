using System;

namespace SLZ.SaveData
{
	public class DataManagerEventArgs : EventArgs
	{
		public readonly string EventName;

		public readonly object EventObject;

		public DataManagerEventArgs(string eventName, object obj)
			: base()
		{
		}
	}
}
