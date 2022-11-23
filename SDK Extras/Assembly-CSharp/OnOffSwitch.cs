using UnityEngine;

namespace SLZ.Bonelab
{
	public class OnOffSwitch : MonoBehaviour
	{
		public Powerable[] ElectricalObj;

		private void Awake()
		{
		}

		public virtual void OnOffEvent(bool isOn)
		{
		}

		protected void OnDestroy()
		{
		}

		public OnOffSwitch()
			: base()
		{
		}
	}
}
