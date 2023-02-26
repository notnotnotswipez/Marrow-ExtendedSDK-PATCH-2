using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	public class SkinnedMeshLink : MeshLink
	{
		public List<SkinnedMeshRenderer> SkinnedMeshes;

		protected override void Start()
		{
		}

		public SkinnedMeshLink()
			: base()
		{
		}
	}
}
