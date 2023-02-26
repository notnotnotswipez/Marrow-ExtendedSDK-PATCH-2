using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class OccluderPortalCtrl : MonoBehaviour
	{
		public OcclusionPortal occlusionPortal;

		public Transform checkTransform;

		public Transform closeTarget;

		private bool _portalOpen;

		private Coroutine _portalDoorCheck;

		private float _closeTolerance;

		private float _waitTime;

		private void Start()
		{
		}

		public void OpenPortal()
		{
		}

		public void ClosePortal()
		{
		}

		private IEnumerator checkPortal()
		{
			return null;
		}

		public OccluderPortalCtrl()
			: base()
		{
		}
	}
}
