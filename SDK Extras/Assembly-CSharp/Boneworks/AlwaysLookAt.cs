using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AlwaysLookAt : ZoneItem
	{
		public Transform local;

		public Transform target;

		public bool isPhysics;

		public ConfigurableJoint jnt_Rotator;

		private void Start()
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		private IEnumerator TickLook()
		{
			return null;
		}

		private void UpdateLookat()
		{
		}

		private void OnDisable()
		{
		}

		public AlwaysLookAt()
			: base()
		{
		}
	}
}
