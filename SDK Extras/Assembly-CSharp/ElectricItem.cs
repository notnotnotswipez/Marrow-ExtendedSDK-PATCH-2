using UnityEngine;

namespace SLZ.Bonelab
{
	[CreateAssetMenu(fileName = "Electronic", menuName = "Variables/Electronic", order = 5)]
	public class ElectricItem : ScriptableObject
	{
		[Header("UI")]
		[Space(5f)]
		public Material Icon;

		public ElectricItem()
			: base()
		{
		}
	}
}
