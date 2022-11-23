using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.SaveData;
using UnityEngine;

namespace SLZ.Props
{
	public class GachaCapsuleSpawner : MonoBehaviour
	{
		[SerializeField]
		private Spawnable gacha;

		private List<SpawnableCrate> cratesToSpawn;

		private bool usedSpawnAll;

		private static PlayerUnlocks u
		{
			get
			{
				return null;
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPalletAdded(string palletBarcode)
		{
		}

		public void UNLOCKALL()
		{
		}

		public void RELOCKALL()
		{
		}

		public void SPAWNUNLOCKGACHA()
		{
		}

		private IEnumerator SpawnGachas()
		{
			return null;
		}

		private UniTaskVoid SpawnGacha(SpawnableCrate crateToLink)
		{
			return default(UniTaskVoid);
		}

		public GachaCapsuleSpawner()
			: base()
		{
		}
	}
}
