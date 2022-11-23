using SLZ.Props.Weapons;
using UnityEngine;

namespace SLZ.Props
{
	public class GrapplingHook : Gun
	{
		[Space(20f)]
		[SerializeField]
		[Header("Grappling Hook Options")]
		private LayerMask collisionLayers;

		[SerializeField]
		private float effectiveRange;

		[SerializeField]
		private float spring;

		[SerializeField]
		private GameObject Hook;

		[SerializeField]
		private Transform AnchorPoint;

		public bool firedAndHooked;

		public ConfigurableJoint hitjoint;

		public GameObject hookie;

		protected override void OnFire()
		{
		}

		public override void Fire()
		{
		}

		private void AttachToOther()
		{
		}

		private void FireHook()
		{
		}

		public GrapplingHook()
			: base()
		{
		}
	}
}
