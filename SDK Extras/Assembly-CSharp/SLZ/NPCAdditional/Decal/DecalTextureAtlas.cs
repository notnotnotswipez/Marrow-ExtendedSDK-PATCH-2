using System;
using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	public class DecalTextureAtlas : ScriptableObject
	{
		[SerializeField]
		[HideInInspector]
		private Material material;

		[HideInInspector]
		[SerializeField]
		private List<AtlasRegion> regions;

		public Material Material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<AtlasRegion> Regions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action<DecalTextureAtlas> OnAtlasChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public Texture2D GetThumbnail(int index)
		{
			return null;
		}

		public Texture2D GetThumbnail(AtlasRegion region)
		{
			return null;
		}

		public void CallOnAtlasChanged()
		{
		}

		public DecalTextureAtlas()
			: base()
		{
		}
	}
}
