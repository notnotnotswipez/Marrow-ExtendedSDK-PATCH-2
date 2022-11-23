using System;
using UnityEngine;

namespace SLZ.Combat
{
	[Serializable]
	public struct MuzzleBreakVariables
	{
		[Tooltip("Muzzle type")]
		public MuzzleBreakType muzzleBreakType;

		[Tooltip("Amount of recoil suppression")]
		[Range(0f, 1f)]
		public float RecoilCompensation;

		[Range(0f, 1f)]
		[Tooltip("Amount of Muzzle Rise suppression")]
		public float MuzzleRiseCompensation;
	}
}
