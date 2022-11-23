using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Unity.MLAgents.SideChannels
{
	public class IncomingMessage : IDisposable
	{
		private byte[] m_Data;

		private Stream m_Stream;

		private BinaryReader m_Reader;

		public IncomingMessage(byte[] data)
			: base()
		{
		}

		public int ReadInt32(int defaultValue = 0)
		{
			return default(int);
		}

		public float ReadFloat32(float defaultValue = 0f)
		{
			return default(float);
		}

		public string ReadString(string defaultValue = default(string))
		{
			return null;
		}

		public IList<float> ReadFloatList(IList<float> defaultValue = default(IList<float>))
		{
			return null;
		}

		public byte[] GetRawBytes()
		{
			return null;
		}

		public void Dispose()
		{
		}

		private bool CanReadMore()
		{
			return default(bool);
		}
	}
}
