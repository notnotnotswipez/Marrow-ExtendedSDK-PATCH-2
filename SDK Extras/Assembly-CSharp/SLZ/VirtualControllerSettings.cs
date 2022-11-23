using System;
using UnityEngine;

namespace SLZ
{
	[Serializable]
	public class VirtualControllerSettings
	{
		[Range(0f, 1f)]
		[Tooltip("Primary to Secondary swing weight (Blends into per-hand swing weight)")]
		public float lookRotationWeight;

		[Tooltip("Per-hand blend twist rotation")]
		[Range(0f, 1f)]
		public float handTwistWeight;

		[Tooltip("Per-hand blend swing rotation")]
		[Range(0f, 1f)]
		public float handSwingWeight;

		[Range(0f, 1f)]
		[Tooltip("Per-hand blend position")]
		public float positionWeight;

		[Range(0f, 90f)]
		[Tooltip("Joint swing limits")]
		public float jointSwingLimit;

		[Tooltip("Joint twist limits")]
		[Range(0f, 90f)]
		public float jointTwistLimit;

		[Tooltip("Swap slip rotation to primary grip")]
		public bool autoTargetUpdatePrimary;

		[Tooltip("Dynamic weights based on hand to hand distance")]
		public bool dynamicHandDistanceWeights;

		public VirtualControllerSettings()
			: base()
		{
		}
	}
}
