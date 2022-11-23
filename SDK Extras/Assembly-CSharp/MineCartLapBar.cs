using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class MineCartLapBar : MonoBehaviour
	{
		[Tooltip("Joint for lapbar")]
		[InspectorDisplayName("Configurable Joint")]
		public ConfigurableJoint cj;

		[Tooltip("needs to be set to allow slow mo to be disabled")]
		public OpenControllerRig openControllerRig;

		[InspectorDisplayName("Seat")]
		[Tooltip("Seat script goes here")]
		public Seat seat;

		[Tooltip("Servo script goes here")]
		[InspectorDisplayName("Servo Script")]
		public Servo servo;

		[Tooltip("The amount of rotation in degrees that will lock the joint")]
		[InspectorDisplayName("Lock Angle")]
		public float lockAngle;

		[Header("Events")]
		[Tooltip("Event to fire on player seated")]
		[SerializeField]
		private UnityEvent OnSeat;

		[Tooltip("Event to fire on player unseated")]
		[SerializeField]
		private UnityEvent OnUnseat;

		[SerializeField]
		[Tooltip("Event to fire on bar locked")]
		private UnityEvent OnBarLocked;

		[Tooltip("Event to fire on bar unlocked")]
		[SerializeField]
		private UnityEvent OnBarUnlocked;

		private Quaternion startRotation;

		private Coroutine _checkingBar;

		public void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnSeated()
		{
		}

		private void OnUnSeated()
		{
		}

		private IEnumerator CoCheckBar()
		{
			return null;
		}

		public bool CheckBar()
		{
			return default(bool);
		}

		public void LockBar()
		{
		}

		public void UnlockBar()
		{
		}

		private void OnDisable()
		{
		}

		public MineCartLapBar()
			: base()
		{
		}
	}
}
