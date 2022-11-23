using SLZ.Props.Weapons;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GunPlatformDiscriminator : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private Gun gun;

		[SerializeField]
		[Header("PC")]
		private MeshRenderer chargingHelperPC;

		[SerializeField]
		private MeshRenderer magazineHelperPC;

		[Header("Quest")]
		[SerializeField]
		private MeshRenderer chargingHelperQ;

		[SerializeField]
		private MeshRenderer magazineHelperQ;

		private void Awake()
		{
		}

		private void SetReferences(bool isQuest)
		{
		}

		public GunPlatformDiscriminator()
			: base()
		{
		}
	}
}
