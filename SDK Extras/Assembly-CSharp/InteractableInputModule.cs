using System.Runtime.InteropServices;
using SLZ.Interaction;
using SLZ.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
{
	[AddComponentMenu("Event/Interactable Input Module")]
	public class InteractableInputModule : VRStandaloneInputModule
	{
		private VRInput m_Input;

		protected override void Awake()
		{
		}

		private bool GetInput(Hand hand, [Out] int index)
		{
			return default(bool);
		}

		protected PointerEventData ModifiedGetTouchPointerEventData(Touch input, [Out] bool pressed, [Out] bool released)
		{
			return null;
		}

		public void SetTrackedInput(Hand hand)
		{
		}

		public void RemoveTrackedInput(Hand hand)
		{
		}

		protected virtual void ModifiedProcessMove(PointerEventData pointerEvent)
		{
		}

		protected void ModifiedHandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
		}

		public InteractableInputModule()
			: base()
		{
		}
	}
}
