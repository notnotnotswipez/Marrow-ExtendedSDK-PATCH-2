using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace ch.sycoforge.Decal
{
	internal class DecalBufferGroup
	{
		public RenderTargetIdentifier[] RenderTargets;

		public RenderTargetIdentifier[] RenderTargetsHDR;

		public HashSet<EasyDecal> Decals;

		public DeferredFlags Flags;

		public int PassIndex;

		[CompilerGenerated]
		private static Comparison<BuiltinRenderTextureType> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1;

		public RenderTargetIdentifier[] GetTargets(Camera camera)
		{
			return null;
		}

		public static int GetPassIndex(DeferredFlags flags)
		{
			return default(int);
		}

		public static RenderTargetIdentifier[] GetRenderTargets(DeferredFlags flags, bool hdr)
		{
			return null;
		}

		private static BuiltinRenderTextureType FlagToTarget(DeferredFlags flag)
		{
			return default(BuiltinRenderTextureType);
		}

		public DecalBufferGroup()
			: base()
		{
		}
	}
}
