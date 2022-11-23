using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SurgeBox : MonoBehaviour
	{
		protected bool m_powered;

		protected float FedInWattage;

		public Manager_Circuit ControlCircuit { get; set; }

		public void AddWattage(float amt)
		{
		}

		public void SubtractWattage(float amt)
		{
		}

		public virtual void PoweredEvent(bool isOn)
		{
		}

		public SurgeBox()
			: base()
		{
		}
	}
}
