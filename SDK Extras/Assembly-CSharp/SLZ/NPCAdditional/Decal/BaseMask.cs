using UnityEngine;

namespace ch.sycoforge.Decal
{
	[ExecuteInEditMode]
	public abstract class BaseMask : MonoBehaviour
	{
		private static Material maskMaterial;

		protected static Material MaskMaterial
		{
			get
			{
				return null;
			}
		}

		protected virtual void Start()
		{
		}

		public virtual void Initialize()
		{
		}

		public BaseMask()
			: base()
		{
		}
	}
}
