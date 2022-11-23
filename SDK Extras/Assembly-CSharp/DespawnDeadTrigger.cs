using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class DespawnDeadTrigger : MonoBehaviour
	{
		private Collider m_Collider;

		public List<AgentLinkControl> agentList;

		private void Start()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void RegisterAgent(AgentLinkControl agent)
		{
		}

		private void UnregisterAgent(AgentLinkControl agent)
		{
		}

		public DespawnDeadTrigger()
			: base()
		{
		}
	}
}
