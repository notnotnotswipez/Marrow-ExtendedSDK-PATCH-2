using SLZ.Marrow.Utilities;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class SeatEvent : MonoBehaviour
	{
		[Tooltip("Seat script goes here")]
		[InspectorDisplayName("Seat")]
		public Seat seat;

		[Header("Events")]
		[Tooltip("Event to fire on player seated")]
		[SerializeField]
		private UnityEvent OnSeat;

		[Tooltip("Event to fire on player unseated")]
		[SerializeField]
		private UnityEvent OnUnseat;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSeated()
		{
		}

		private void OnUnSeated()
		{
		}

		public SeatEvent()
			: base()
		{
		}
	}
}
