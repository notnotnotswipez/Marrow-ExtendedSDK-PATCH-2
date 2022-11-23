using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Props
{
	public class PropKnife : CylinderGrip
	{
		public ConfigurableJoint jnt_blade;

		public AudioSource src_Audio;

		public AudioClip clip_knifeUp;

		public AudioClip clip_knifeDown;

		public bool knifeUp;

		private bool clicked;

		private void FlickKnife()
		{
		}

		public override void OnHandAttachedUpdate(Hand hand)
		{
		}

		public PropKnife()
			: base()
		{
		}
	}
}
