using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Marrow.VoidLogic;
using SLZ.Props.Weapons;
using SLZ.SaveData;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Bonelab
{
	public class Control_Gashapon : MonoBehaviour
	{
		public Servo servo;

		public Rigidbody leverRigidBody;

		public ConfigurableJoint leverConfigurableJoint;

		public SourceNode pusherPower;

		[SerializeField]
		private int _itemPrice;

		[SerializeField]
		private int _lightBullets;

		[SerializeField]
		private int _mediumBullets;

		[SerializeField]
		private int _heavyBullets;

		[SerializeField]
		private bool _opened;

		[SerializeField]
		private bool _unlocked;

		[SerializeField]
		private TextMeshPro _bulletBalanceTextmesh;

		[SerializeField]
		private TextMeshPro _refundTextmesh;

		[SerializeField]
		private AmmoReciever reciever;

		[SerializeField]
		private Spawnable gachaSpawnable;

		[SerializeField]
		private Spawnable lightRefundSpawnable;

		[SerializeField]
		private Spawnable mediumRefundSpawnable;

		[SerializeField]
		private Spawnable heavyRefundSpawnable;

		[SerializeField]
		private AudioClip despenceClip;

		[SerializeField]
		private AudioClip emptyClip;

		[SerializeField]
		private AudioClip lowFundsClip;

		[SerializeField]
		private AudioMixerGroup _mixergroup;

		public Transform giveChangeTransform;

		public Transform gachaSpawnTransform;

		private static System.Random random;

		private bool leverCycle;

		private static PlayerUnlocks u
		{
			get
			{
				return null;
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void CheckLever()
		{
		}

		public void GiveChange()
		{
		}

		[ContextMenu("AddAmmo")]
		public void AddAmmo()
		{
		}

		[ContextMenu("StartSpawnLoop")]
		public void StartSpawnLoop()
		{
		}

		private IEnumerator SpawnLoop()
		{
			return null;
		}

		public void InsertMagazine(Magazine magazine)
		{
		}

		public void AddBullets(int addedBullets, int type)
		{
		}

		public void CheckGacha()
		{
		}

		private void SpawnGacha(string barcode)
		{
		}

		private IEnumerator PusherPaddle()
		{
			return null;
		}

		public Control_Gashapon()
			: base()
		{
		}
	}
}
