using System;
using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Mods
{
	public class BonelabSerializableDictionaries : MonoBehaviour
	{
		[Serializable]
		public class StringAvatarDictionary : SerializableDictionary<string, SLZ.VRMK.Avatar>
		{
			public StringAvatarDictionary()
				: base()
			{
			}
		}

		public BonelabSerializableDictionaries()
			: base()
		{
		}
	}
}
