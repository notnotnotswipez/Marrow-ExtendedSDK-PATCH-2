using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.MLAgents.SideChannels
{
	internal class EnvironmentParametersChannel : SideChannel
	{
		private Dictionary<string, Func<float>> m_Parameters;

		private Dictionary<string, Action<float>> m_RegisteredActions;

		private const string k_EnvParamsId = "534c891e-810f-11ea-a9d0-822485860400";

		internal EnvironmentParametersChannel()
			: base()
		{
		}

		protected override void OnMessageReceived(IncomingMessage msg)
		{
		}

		public float GetWithDefault(string key, float defaultValue)
		{
			return default(float);
		}

		public void RegisterCallback(string key, Action<float> action)
		{
		}
	}
}
