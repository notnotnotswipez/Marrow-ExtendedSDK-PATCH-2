using UnityEngine;

namespace SLZ.Props
{
	public class GlassHandler : MonoBehaviour
	{
		public enum GlassType
		{
			none = 0,
			transparent = 1,
			disable = 2,
			opaque = 3,
			custom = 4
		}

		[Tooltip("Glass type to use on PC")]
		public GlassType override_PC;

		[Tooltip("Glass type to use on Android")]
		public GlassType override_Android;

		[Tooltip("Full transparent glass material to use")]
		[Space(10f)]
		public Material mat_transparent;

		[Tooltip("Opaque glass material to use (black/grey or reflective likely)")]
		public Material mat_opaque;

		[Tooltip("Glass mesh to change material")]
		[Space(10f)]
		public MeshRenderer mesh_glass;

		[Tooltip("Use this for custom glass object such as card edges etc.")]
		public GameObject customObject;

		[Tooltip("Necessary if baked object has multiple materials (glass isn't separate)")]
		public int specificMat;

		private void Start()
		{
		}

		public void SWITCHGLASS(GlassType glassType = GlassType.none)
		{
		}

		public GlassHandler()
			: base()
		{
		}
	}
}
