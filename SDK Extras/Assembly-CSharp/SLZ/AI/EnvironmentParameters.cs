using System;
using Unity.MLAgents.SideChannels;

namespace Unity.MLAgents
{
	public sealed class EnvironmentParameters
	{
		private readonly EnvironmentParametersChannel m_Channel;

		internal EnvironmentParameters()
			: base()
		{
		}

		public float GetWithDefault(string key, float defaultValue)
		{
			return default(float);
		}

		public void RegisterCallback(string key, Action<float> action)
		{
		}

		internal void Dispose()
		{
		}
	}
}
