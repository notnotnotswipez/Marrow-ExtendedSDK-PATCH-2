using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class CraneControlBox : MonoBehaviour
	{
		public GameObject lineRenderers;

		public JoystickForwarder joystick;

		public Control_PowerLever zControls;

		public ButtonToggle button;

		public Powerable_Joint[] craneSegments;

		public Powerable_Joint[] craneGantry;

		public Material craneLightOn;

		public Material craneLightOff;

		public GameObject[] lightMeshes;

		public List<Renderer> lightRenderers;

		public GameObject[] craneRunningColliders;

		public Collider[] craneMainColliders;

		public PhysicMaterial zeroFriction;

		public PhysicMaterial steel;

		public Rigidbody[] rigidbodies;

		public ConfigurableJoint[] configurableJoints;

		private Vector3[] initialRBPosition;

		private Quaternion[] initialRBRotation;

		private HandJointConfiguration[] savedJointConfiguration;

		private IEnumerator craneResetCoroutine;

		private IEnumerator coroutine;

		public bool isPowered;

		private bool craneDeactivating;

		private bool blockAction;

		private bool inCraneVolume;

		private void Start()
		{
		}

		public void DeactivateCrane()
		{
		}

		public void FULLCRANERESET()
		{
		}

		public IEnumerator FullCraneResetCoroutine()
		{
			return null;
		}

		private IEnumerator Deactivation()
		{
			return null;
		}

		public void ActivateCrane()
		{
		}

		private void Activation()
		{
		}

		public void ActivateCraneColliders()
		{
		}

		public void DeactivateCraneColliders()
		{
		}

		public CraneControlBox()
			: base()
		{
		}
	}
}
