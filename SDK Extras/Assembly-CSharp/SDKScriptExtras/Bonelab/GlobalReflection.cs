using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(ReflectionProbe))]
	public class GlobalReflection : MonoBehaviour
	{
		[HideInInspector]
		[SerializeField]
		private ReflectionProbe rp;

		private bool triggermade;

		private BoxCollider boxCol;

		private void Reset()
		{
		}

		public void SetGlobalReflection()
		{
		}

		public void ClearGlobalReflection()
		{
		}

		private void MakeTriggerCol()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void CheckVolume()
		{
		}

		public GlobalReflection()
			: base()
		{
		}
	}
}
