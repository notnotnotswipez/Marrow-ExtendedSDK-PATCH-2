using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Props
{
	public class PropFlashlight : CylinderGrip
	{
		public GameObject LightStuff;

		public AudioSource src_Audio;

		public AudioClip clip_downClick;

		public AudioClip clip_upClick;

		public bool lightOn;

		public Renderer[] renderers;

		[ColorUsage(true, true)]
		public Color onColor;

		[ColorUsage(true, true)]
		public Color offColor;

		private bool clicked;

		protected override void Start()
		{
		}

		private void SwitchLight()
		{
		}

		public override void OnHandAttachedUpdate(Hand hand)
		{
		}

		public PropFlashlight()
			: base()
		{
		}
	}
}
