using System;
using UnityEngine;

namespace SLZ.UI
{
	public class ScrollElementsContainer : MonoBehaviour
	{
		public Action OnContainerChildrenChanged;

		private void OnTransformChildrenChanged()
		{
		}

		public ScrollElementsContainer()
			: base()
		{
		}
	}
}
