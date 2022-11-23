using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Utilities
{
	public class GenericOnDestroy : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent DestroyEvent;

		private void OnDestroy()
		{
		}

		public GenericOnDestroy()
			: base()
		{
		}
	}
}
