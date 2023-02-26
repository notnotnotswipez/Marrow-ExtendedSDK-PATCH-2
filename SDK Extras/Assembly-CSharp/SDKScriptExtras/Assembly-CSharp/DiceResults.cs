using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

public class DiceResults : MonoBehaviour
{
	[Serializable]
	public class DiceResultObject
	{
		public UnityEvent resultEvent;

		public Spawnable vfxSpawnable;

		public float sfxVolume;

		public AudioClip[] sfx;

		public DiceResultObject()
			: base()
		{
		}
	}

	public DiceResultObject[] resultObjects;

	public AudioMixerGroup outputMixer;

	private AudioPlayer ap;

	public void Awake()
	{
	}

	public void RollComplete(int results)
	{
	}

	public DiceResults()
		: base()
	{
	}
}
