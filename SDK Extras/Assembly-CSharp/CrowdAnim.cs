using UnityEngine;

namespace SLZ.Bonelab
{
	public class CrowdAnim : MonoBehaviour
	{
		[SerializeField]
		private float _posDiff;

		private float t;

		private float timer;

		[Range(0.01f, 100f)]
		[SerializeField]
		private float animSpeed;

		private void Start()
		{
		}

		public void ToggleExcitement(bool enable)
		{
		}

		private void Update()
		{
		}

		public CrowdAnim()
			: base()
		{
		}
	}
}
