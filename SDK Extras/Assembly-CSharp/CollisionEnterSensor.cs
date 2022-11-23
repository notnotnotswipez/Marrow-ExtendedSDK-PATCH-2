using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Combat
{
	public class CollisionEnterSensor : MonoBehaviour
	{
		public float minVelocityDeltaSqr;

		private void OnCollisionEnter(Collision c)
		{
		}

		public CollisionEnterSensor()
			: base()
		{
		}
	}
}
