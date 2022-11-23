using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[RequireComponent(typeof(Collider))]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Trigger")]
	public class TriggerNode : BaseNode
	{
		public enum TriggerBehavior
		{
			Always = 0,
			Once = 1,
			Pinned = 2
		}

		[SerializeField]
		[Tooltip("Trigger Behavior:\nAlways => Enter and Exit\nOnce => Enter and Exit, once\nPinned => Enter (pin to \"on\" state)")]
		private TriggerBehavior _triggerBehavior;

		[Tooltip("Limit trigger to player only")]
		[SerializeField]
		private bool _playerOnly;

		[Tooltip("Limit trigger to player or NPC only")]
		[SerializeField]
		private bool _playerOrNpcOnly;

		[Tooltip("Limit trigger to a specific object collision. CONFLICTS WITH: Player Only")]
		[SerializeField]
		private GameObject _triggerObject;

		private bool _isTriggered;

		private bool _hasBeenTriggered;

		private float _multiplier;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		protected override float CalculateValue()
		{
			return default(float);
		}

		public override IReadOnlyList<InputDescription> DescribeInputs()
		{
			return null;
		}

		public TriggerNode()
			: base()
		{
		}
	}
}
