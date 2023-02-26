using System;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Serializable]
	internal class TransformObserver
	{
		[SerializeField]
		[HideInInspector]
		private Vector3 lastPosition;

		[SerializeField]
		[HideInInspector]
		private Vector3 lastScale;

		[HideInInspector]
		[SerializeField]
		private Quaternion lastRotation;

		[SerializeField]
		[HideInInspector]
		private Transform transform;

		public TransformObserver(Transform transform)
			: base()
		{
		}

		public OrientationChange CheckTransformChange()
		{
			return default(OrientationChange);
		}
	}
}
