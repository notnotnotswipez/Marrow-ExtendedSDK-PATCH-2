using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class IndependentSaver : MonoBehaviour
	{
		public string LevelKey { get; set; }

		public Saveable Saveable { get; set; }

		public void UpdateSave()
		{
		}

		public IndependentSaver()
			: base()
		{
		}
	}
}
