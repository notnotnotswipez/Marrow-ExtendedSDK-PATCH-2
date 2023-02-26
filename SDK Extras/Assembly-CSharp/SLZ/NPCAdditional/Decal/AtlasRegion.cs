using System;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Serializable]
	public class AtlasRegion
	{
		[SerializeField]
		private string name;

		[SerializeField]
		private Rect region;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Rect Region
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public float AspectRatio
		{
			get
			{
				return default(float);
			}
		}

		public override bool Equals(object other)
		{
			return default(bool);
		}

		public virtual bool Equals(AtlasRegion other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public AtlasRegion()
			: base()
		{
		}
	}
}
