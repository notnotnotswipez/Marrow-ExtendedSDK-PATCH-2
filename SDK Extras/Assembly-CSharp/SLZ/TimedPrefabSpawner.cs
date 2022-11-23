using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Utilities
{
	public class TimedPrefabSpawner : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("Spawnable")]
		private Spawnable spawnable;

		[SerializeField]
		[Tooltip("Spawn Interval")]
		private float spawnInterval;

		[SerializeField]
		[Tooltip("Ignore Colliders")]
		private Collider[] ignoreColliders;

		private IEnumerator coroutine;

		private bool doSpawnLoop;

		private void Awake()
		{
		}

		public void ACTIVATESPAWNER()
		{
		}

		public void DEACTIVATESPAWNER()
		{
		}

		private IEnumerator SpawnLoop()
		{
			return null;
		}

		public void SpawnPrefab()
		{
		}

		public TimedPrefabSpawner()
			: base()
		{
		}
	}
}
