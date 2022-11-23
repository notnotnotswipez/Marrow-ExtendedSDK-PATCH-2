using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Proxy;
using UnityEngine;

namespace SLZ.Mods
{
	public class GripProxyMap : BoneProxyMap<GripProxy, Grip>
	{
		protected override void MapProperties()
		{
		}

		public override void BeforeGenerateReal()
		{
		}

		public override void MapMethods()
		{
		}

		public GripProxyMap()
			: base()
		{
		}
	}
}
