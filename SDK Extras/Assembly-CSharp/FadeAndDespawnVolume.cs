using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Rendering;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Volume))]
	public class FadeAndDespawnVolume : SpawnEvents
	{
		private static ComponentCache<FadeAndDespawnVolume> _cache;

		public Volume volume;

		public Action onComplete;

		public float duration;

		private float startValue;

		private float endValue;

		public GameObject fadingQuad;

		private Material mat;

		private Color black;

		private Color clear;

		public static ComponentCache<FadeAndDespawnVolume> Cache
		{
			get
			{
				return null;
			}
		}

		protected void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		protected override void OnSpawn(GameObject go)
		{
		}

		private UniTaskVoid FadeOverTime(float seconds)
		{
			return default(UniTaskVoid);
		}

		private void SetValues(float lerper)
		{
		}

		public FadeAndDespawnVolume()
			: base()
		{
		}
	}
}
