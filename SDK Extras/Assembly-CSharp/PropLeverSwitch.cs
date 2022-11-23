using SLZ.Bonelab;
using SLZ.Interaction;

namespace SLZ.Props
{
	public class PropLeverSwitch : CylinderGrip
	{
		public Control_PowerLever ctrl_lever;

		public override void OnAttachedToHand(Hand hand)
		{
		}

		public override void OnDetachedFromHand(Hand hand)
		{
		}

		public PropLeverSwitch()
			: base()
		{
		}
	}
}
