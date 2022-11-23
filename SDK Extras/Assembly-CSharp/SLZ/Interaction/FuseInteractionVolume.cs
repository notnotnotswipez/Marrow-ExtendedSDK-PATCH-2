using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class FuseInteractionVolume : InteractionVolume
	{
		public Transform targetPos;

		public Collider[] recieverColliders;

		private bool m_isFuseInserted;

		private CylinderFuseGrip m_fuseGrip;

		private Control_SurgeBox m_fuseBox;

		[Tooltip("Assign the maximum wattage cap before the fuse blows")]
		[Space(10f)]
		[Header("FUSE DATA")]
		[SerializeField]
		private float m_FuseBlowoutCap;

		public bool FuseIn
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsFuseBlown(float WattAmt)
		{
			return default(bool);
		}

		private void Start()
		{
		}

		protected override void OnHoverStart(InteractableHost host)
		{
		}

		protected override void OnHoverEnd(InteractableHost host)
		{
		}

		protected override void OnHoverUpdate(InteractableHost host)
		{
		}

		private void M_InsertFuse(InteractableHost host)
		{
		}

		public void RemoveFuse(IGrippable host)
		{
		}

		private IEnumerator CoFuseInteractionCooldown(bool isInserted)
		{
			return null;
		}

		public FuseInteractionVolume()
			: base()
		{
		}
	}
}
