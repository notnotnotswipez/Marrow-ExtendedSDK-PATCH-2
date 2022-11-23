using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Data;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class Arena_SpawnCapsule : MonoBehaviour
	{
		[SerializeField]
		private float maxDistFromCenter;

		[SerializeField]
		private SphereCollider expandCollider;

		[SerializeField]
		private TrailRenderer trailRend;

		[SerializeField]
		private AudioClip beepClip;

		[SerializeField]
		private AudioClip explodeClip;

		[SerializeField]
		[Range(0.25f, 1.5f)]
		private float finalExpandRadius;

		public UnityEvent OnSpawn;

		public void OnLaunchedArena(Arena_GameController arenaGameController, EnemyProfile enemyProfile)
		{
		}

		private IEnumerator CoLaunchSequenceArena(Arena_GameController arenaGameController, EnemyProfile enemyProfile)
		{
			return null;
		}

		public Arena_SpawnCapsule()
			: base()
		{
		}
	}
}
