using System;
using System.Collections.Generic;
using SLZ.Props;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class NarrativeStateRadioAdaptor : MonoBehaviour
	{
		[Serializable]
		public class NarrativeStateRadioPair
		{
			public RadioSong radioSong;

			public NarrativeState narrativeState;

			public NarrativeStateRadioPair()
				: base()
			{
			}
		}

		public NarrativeManager narrativeManager;

		public RadioManager radioManager;

		public List<NarrativeStateRadioPair> pairList;

		private Dictionary<RadioSong, NarrativeState> narrativeRadioLookUp;

		private void Start()
		{
		}

		public void OverrideSongChange(RadioSong overrideSong)
		{
		}

		public NarrativeStateRadioAdaptor()
			: base()
		{
		}
	}
}
