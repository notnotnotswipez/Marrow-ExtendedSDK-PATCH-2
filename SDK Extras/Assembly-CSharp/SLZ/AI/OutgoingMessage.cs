using System;
using System.IO;

namespace Unity.MLAgents.SideChannels
{
	public class OutgoingMessage : IDisposable
	{
		private BinaryWriter m_Writer;

		private MemoryStream m_Stream;

		public void Dispose()
		{
		}

		public void WriteInt32(int i)
		{
		}

		public void WriteFloat32(float f)
		{
		}

		public void WriteString(string s)
		{
		}

		internal byte[] ToByteArray()
		{
			return null;
		}

		public OutgoingMessage()
			: base()
		{
		}
	}
}
