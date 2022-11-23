using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace SLZ.Bonelab
{
	public class GameControl_SprintBridge04 : BonelabInternalGameControl
	{
		public RigManager rM;

		public Player_Health playerHealth;

		public AvatarCrateReference avatarOverride;

		public UnityEvent OnDeathEvent;

		public GameObject[] LoadButtons;

		[SerializeField]
		private GenericCrateReference unlockCrate;

		[FormerlySerializedAs("avatarGatcha")]
		[SerializeField]
		private GameObject avatarGacha;

		private IEnumerator KillPlayerCoroutine;

		private new void Start()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void PlayerDeath()
		{
		}

		public void SwitchAvatar()
		{
		}

		private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
		{
			return default(UniTaskVoid);
		}

		public void KillPlayerFast()
		{
		}

		private IEnumerator KillPlayerAndReset()
		{
			return null;
		}

		public override void DoLevelComplete()
		{
		}

		private void ButtonsSetup()
		{
		}

		public GameControl_SprintBridge04()
			: base()
		{
		}
	}
}
