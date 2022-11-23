using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Manager_Circuit : MonoBehaviour
	{
		[Space(5f)]
		[Tooltip("Assign a value if there is an object that functions like a fusebox")]
		[Header("Surge BOX")]
		public SurgeBox FuseBoxRef;

		[Tooltip("Used if you don't want a powerSource connected.")]
		[Header("ELECTRONICS")]
		[Space(5f)]
		public bool isPowerSource;

		[Tooltip("The minumum voltage required to power this circuit")]
		public float MinimumVoltage;

		public float TotalVoltage;

		[Space(3f)]
		public List<PowerSocket> PowerSockets;

		public List<Powerable> Electronics;

		[Tooltip("Checked if you want it to only work with a specific Power Source.")]
		[Header("SPECIFIC POWERSOURCE")]
		[Space(10f)]
		public bool SpecificPSMode;

		public bool hasPowerSources
		{
			get
			{
				return default(bool);
			}
		}

		public bool isInfinitePower
		{
			get
			{
				return default(bool);
			}
		}

		public bool hasReqCharge
		{
			get
			{
				return default(bool);
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void CurrentOnOff(bool isOn)
		{
		}

		public void DestroyedPowerable(Powerable obj)
		{
		}

		private void OnDestroy()
		{
		}

		public Manager_Circuit()
			: base()
		{
		}
	}
}
