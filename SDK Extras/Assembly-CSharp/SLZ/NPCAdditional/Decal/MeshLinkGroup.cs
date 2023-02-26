using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	public class MeshLinkGroup : MonoBehaviour
	{
		[HideInInspector]
		public List<MeshLink> Links;

		protected virtual void Start()
		{
		}

		public void Clear()
		{
		}

		public void Initialize()
		{
		}

		public MeshLinkGroup()
			: base()
		{
		}
	}
}
