using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[DisallowMultipleComponent]
	public abstract class MeshLink : MonoBehaviour
	{
		[HideInInspector]
		public List<MeshFilter> MeshFilters;

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void Start()
		{
		}

		public MeshLink()
			: base()
		{
		}
	}
}
