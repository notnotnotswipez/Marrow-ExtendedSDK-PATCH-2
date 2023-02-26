using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	public class DynamicMask : BaseMask
	{
		private IList<SkinnedMeshRenderer> skinnedMeshRenderers;

		[CompilerGenerated]
		private static Predicate<Material> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1;

		protected override void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		private void InjectMaskPasses(bool add)
		{
		}

		private void InjectMaskPass(SkinnedMeshRenderer skinnedMeshRenderer, bool add)
		{
		}

		public DynamicMask()
			: base()
		{
		}
	}
}
