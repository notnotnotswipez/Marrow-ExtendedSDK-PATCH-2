using SLZ.Props;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class DestructibleDamageForwarder : MonoBehaviour
	{
		public ObjectDestructable[] destructables;

		public float attackDamage;

		public void BREAKEVENT()
		{
		}

		public DestructibleDamageForwarder()
			: base()
		{
		}
	}
}
