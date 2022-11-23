using System.Runtime.CompilerServices;
using SLZ.Marrow.Proxy;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Mods
{
	public class AvatarProxyMap : BoneProxyMap<AvatarProxy, SLZ.VRMK.Avatar>
	{
		public override void MapMethods()
		{
		}

		protected override void MapProperties()
		{
		}

		public override void AfterGenerateReal()
		{
		}

		public AvatarProxyMap()
			: base()
		{
		}
	}
}
