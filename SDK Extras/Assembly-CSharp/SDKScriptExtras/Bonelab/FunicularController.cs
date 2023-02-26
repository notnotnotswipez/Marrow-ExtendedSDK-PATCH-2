using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class FunicularController : MonoBehaviour
	{
		public Cart cart;

		public ParticleSystem[] SteamVent;

		public UnityEvent sealBreakSFX;

		public UnityEvent gasRushSFX;

		public UnityEvent klaxonSFX;

		public UnityEvent startSFX;

		public UnityEvent stopSFX;

		private IEnumerator CartFxCoroutine;

		public void CartGo()
		{
		}

		private IEnumerator CartGoCoroutine()
		{
			return null;
		}

		public void CartForwards()
		{
		}

		private IEnumerator CartForwardsCoroutine()
		{
			return null;
		}

		public void CartBackwards()
		{
		}

		private IEnumerator CartBackwardsCoroutine()
		{
			return null;
		}

		public void StopVFX()
		{
		}

		private IEnumerator StopVFXCoroutine()
		{
			return null;
		}

		public FunicularController()
			: base()
		{
		}
	}
}
