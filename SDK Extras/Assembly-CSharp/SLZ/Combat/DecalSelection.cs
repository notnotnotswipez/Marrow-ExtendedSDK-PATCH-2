using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Combat
{
	public class DecalSelection : MonoBehaviour
	{
		private static ComponentCache<DecalSelection> _cache;

		public DecalMaterials decalMaterials;

		[SerializeField]
		private GameObject LightCone;

		[HideInInspector]
		public ImpactProperties SurfaceProperties;

		public static ComponentCache<DecalSelection> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public void PickDecal()
		{
		}

		public void PickDecal(AttackType attackType)
		{
		}

		private void OnDisable()
		{
		}

		public DecalSelection()
			: base()
		{
		}
	}
}
