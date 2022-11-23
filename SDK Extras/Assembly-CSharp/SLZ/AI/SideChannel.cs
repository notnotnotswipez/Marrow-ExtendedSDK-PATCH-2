using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.MLAgents.SideChannels
{
	public abstract class SideChannel
	{
		internal List<byte[]> MessageQueue;

		public Guid ChannelId { get; protected set; }

		internal void ProcessMessage(byte[] msg)
		{
		}

		protected abstract void OnMessageReceived(IncomingMessage msg);

		protected void QueueMessageToSend(OutgoingMessage msg)
		{
		}

		public SideChannel()
			: base()
		{
		}
	}
}
