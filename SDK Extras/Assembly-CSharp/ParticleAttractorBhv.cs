using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(ParticleSystem))]
	public class ParticleAttractorBhv : MonoBehaviour
	{
		[HideInInspector]
		[SerializeField]
		private ParticleSystem AffectedParticles;

		public float LerpTime;

		private Transform m_rTransform;

		private ParticleSystem.Particle[] m_rParticlesArray;

		private bool m_bWorldPosition;

		private int m_iNumActiveParticles;

		private Transform m_vParticlesTarget;

		private float m_fCursor;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private IEnumerator ParticleAttractor()
		{
			return null;
		}

		public void Setup()
		{
		}

		public ParticleAttractorBhv()
			: base()
		{
		}
	}
}
