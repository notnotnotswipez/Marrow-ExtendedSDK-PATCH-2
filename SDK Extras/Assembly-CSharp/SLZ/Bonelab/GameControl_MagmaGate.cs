using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Bonelab
{
	public class GameControl_MagmaGate : BonelabInternalGameControl
	{
		public AvatarCrateReference avatarOverride;

		public GameObject[] LoadButtons;

		public GameObject[] LoadButtonsForComplete;

		[SerializeField]
		private GenericCrateReference unlockCrate;

		[SerializeField]
		[FormerlySerializedAs("avatarGatcha")]
		private GameObject avatarGacha;

		public GameObject doorArt;

		public GameObject[] laserBeams;

		public GameObject[] fizzleEffects;

		private new void Start()
		{
		}

		public void SwitchAvatar()
		{
		}

		private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
		{
			return default(UniTaskVoid);
		}

		public override void DoLevelComplete()
		{
		}

		private void ButtonsSetup()
		{
		}

		public void ObjectiveCompleteSetup()
		{
		}

		public void LoseSequence()
		{
		}

		private void DoorDissolve()
		{
		}

		public GameControl_MagmaGate()
			: base()
		{
		}
	}
}
