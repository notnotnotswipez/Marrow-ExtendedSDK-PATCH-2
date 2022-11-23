using UnityEngine;

namespace SLZ.Bonelab
{
	public class Powerable_Desk : Powerable
	{
		public float map_low;

		public float map_high;

		public ConfigurableJoint jnt_this;

		public GameObject obj_Report;

		public override void SwitchPowerOnOff(bool isOn)
		{
		}

		public override void VoltageToObject(float voltage, int id = 0)
		{
		}

		private void SendReport()
		{
		}

		public Powerable_Desk()
			: base()
		{
		}
	}
}
