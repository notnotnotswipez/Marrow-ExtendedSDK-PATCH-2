using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ
{
	public class DoneTurretController : MonoBehaviour
	{
		[Header("References")]
		public Rigidbody turretRb;

		public TurretHeadController turret;

		public Transform targetTransform;

		public Transform firePointTransform;

		public SphereCollider playerTrigger;

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

		private float lastFireTime;

		private float burstLengthTime;

		private float coolDownLengthTime;

		private IEnumerator turretLoop;

		private IEnumerator fireSequence;

		private bool killMode;

		public void Start()
		{
		}

		public void FoundPlayer()
		{
		}

		public void LostPlayer()
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

		public void KILLMODE(bool killOn)
		{
		}

		public DoneTurretController()
			: base()
		{
		}
	}
}
