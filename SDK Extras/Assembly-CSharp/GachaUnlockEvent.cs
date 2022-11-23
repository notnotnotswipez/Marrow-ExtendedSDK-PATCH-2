using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.SaveData;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Props
{
	public class GachaUnlockEvent : MonoBehaviour
	{
		public GenericCrateReference selectedCrate;

		[SerializeField]
		private Spawnable vfxSpawnable;

		public Transform vfxPoint;

		public UnityEvent gachaPopEvent;

		private bool used;

		private static PlayerUnlocks u
		{
			get
			{
				return null;
			}
		}

		public void Awake()
		{
		}

		public void UNLOCKITEM()
		{
		}

		public void POPFX(Spawnable effect)
		{
		}

		private UniTaskVoid PopFXAsync(Spawnable effect)
		{
			return default(UniTaskVoid);
		}

		public GachaUnlockEvent()
			: base()
		{
		}
	}
}
