using UnityEngine;

namespace SLZ.Bonelab
{
	public class Powerable_Motor : Powerable
	{
		[Header("VOLTAGE")]
		public bool isBinary;

		[Space(5f)]
		[Range(-1f, 1f)]
		public float cur_InputVoltage;

		private float att_Voltage;

		[Range(-1f, 1f)]
		[Space(5f)]
		public float min_InputVoltage;

		[Range(-1f, 1f)]
		public float max_InputVoltage;

		[Space(5f)]
		public float min_TargetVoltage;

		public float max_TargetVoltage;

		[Space(5f)]
		[Header("MOTOR CONTROL")]
		[SerializeField]
		private float m_TargetVelocity;

		[SerializeField]
		private float m_MaxForce;

		[SerializeField]
		private float m_PositionDamper;

		private ConfigurableJoint jnt_this;

		private Rigidbody rb_this;

		private float stored_Draw;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public override void SwitchPowerOnOff(bool isOn)
		{
		}

		public override void VoltageToObject(float voltage, int id = 0)
		{
		}

		private void SETJOINT(float voltage = 1f)
		{
		}

		public Powerable_Motor()
			: base()
		{
		}
	}
}
