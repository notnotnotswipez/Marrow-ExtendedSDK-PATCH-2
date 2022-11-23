using UnityEngine;

namespace SLZ.Bonelab
{
	public class RandomizeRotation : MonoBehaviour
	{
		private enum Direction
		{
			Up = 0,
			Forward = 1,
			Right = 2,
			All = 3
		}

		[SerializeField]
		private bool RotateOnEnable;

		[SerializeField]
		[Header("Degree range to rotate")]
		[Range(0f, 360f)]
		private float Rotation;

		[SerializeField]
		[Tooltip("Axis to rotate on")]
		private Direction direction;

		private void OnEnable()
		{
		}

		public void RotateTheThing()
		{
		}

		public RandomizeRotation()
			: base()
		{
		}
	}
}
