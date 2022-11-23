using SLZ.Combat;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.VFX
{
	public class DecalCache : MonoBehaviour
	{
		public enum DecalType
		{
			mesh = 0,
			plane = 1
		}

		private static ComponentCache<DecalCache> _cache;

		private Color tintingColor;

		private Material CustomMat;

		private AssetPoolee poolee;

		public static ComponentCache<DecalCache> Cache
		{
			get
			{
				return null;
			}
		}

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		public void SetMaterial(Material material)
		{
		}

		public void SetObject(GameObject GO)
		{
		}

		public void SetGenerationType(ImpactPropertiesVariables.DecalType decalType)
		{
		}

		private void OnEnable()
		{
		}

		public void TintMaterial(Color color)
		{
		}

		public DecalCache()
			: base()
		{
		}
	}
}
