using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ
{
	public class ChopperTurretController : MonoBehaviour
	{
		[Header("References")]
		public Rigidbody turretRb;

		public SplineJoint splineJoint;

		public TurretHeadController turret;

		public ConfigurableJoint blades;

		public Transform targetTransform;

		public Transform firePointTransform;

		public SphereCollider playerTrigger;

		[Header("Chopper Behavior (Speed/Damper/MaxForce)")]
		public Vector3 fastDriveSettings;

		public Vector3 slowDriveSettings;

		public float speedTransitionTime;

		[Header("Turret Behavior")]
		public float agroRange;

		public float chargeTime;

		public float burstLength;

		public float fireRate;

		public float burstCoolDown;

		[Range(0f, 10f)]
		public float maxBulletSpread;

		[Range(0f, 10f)]
		public float minBulletSpread;

		[Header("Audio")]
		public AudioMixerGroup outputMixer;

		public AudioClip[] turretCharge;

		public AudioSource chopperAudioSource;

		public AudioClip chopperFast;

		public AudioClip chopperSlow;

		private bool isSlowmoClip;

		private float lastFireTime;

		private float burstLengthTime;

		private float coolDownLengthTime;

		private IEnumerator turretLoop;

		private IEnumerator fireSequence;

		private bool killMode;

		private Vector3 jointDriveCurrent;

		private Vector3 jointDriveTarget;

		private Vector3 jointDriveVel;

		private bool chopperDestroyed;

		public void Start()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void FoundPlayer()
		{
		}

		public void LostPlayer()
		{
		}

		public void PlayerDeath()
		{
		}

		private IEnumerator TurretUpdateLoop()
		{
			return null;
		}

		private IEnumerator FireTurret()
		{
			return null;
		}

		private void FixedUpdate()
		{
		}

		public void KILLMODE(bool killOn)
		{
		}

		public void DestructChopper()
		{
		}

		public ChopperTurretController()
			: base()
		{
		}
	}
}
