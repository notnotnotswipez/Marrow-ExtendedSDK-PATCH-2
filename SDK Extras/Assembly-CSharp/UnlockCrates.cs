using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.SaveData;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class UnlockCrates : MonoBehaviour
	{
		[Tooltip("Level Crates to be whitelisted")]
		[Header("Crates to be unlocked on scene loading")]
		public LevelCrate[] levelCrates;

		[Tooltip("Avatar and Spawnable Crates to be whitelisted")]
		public SpawnableCrate[] spawnableCrates;

		private static PlayerUnlocks u
		{
			get
			{
				return null;
			}
		}

		public void SetUnlocked()
		{
		}

		public UnlockCrates()
			: base()
		{
		}
	}
}
