using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.SaveData;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SceneBootstrapper_Bonelab : MonoBehaviour
	{
		public LevelCrateReference MenuHollowCrateRef;

		public LevelCrateReference VoidG114CrateRef;

		public LevelCrateReference LevelLoaderCrateRef;

		public TextMeshProUGUI tmp;

		public GameObject Overlay2d;

		private static PlayerProgression p
		{
			get
			{
				return null;
			}
		}

		private UniTaskVoid Start()
		{
			return default(UniTaskVoid);
		}

		private void UpdateLog(string msg)
		{
		}

		public SceneBootstrapper_Bonelab()
			: base()
		{
		}
	}
}
