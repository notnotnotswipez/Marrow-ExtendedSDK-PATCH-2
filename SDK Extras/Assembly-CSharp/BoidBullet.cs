using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PuppetMasta;
using SLZ.AI;
using UnityEngine;

public class BoidBullet : MonoBehaviour
{
	public delegate void OnDespawnDelegate(BehaviourBoidAgent_SlicedInference boid);

	public float maxTimeAlive;

	public float currentTimeAlive;

	public BehaviourBoidAgent_SlicedInference boidAgent;

	private TriggerRefProxy temp_trp;

	public IEnumerator DespawnCounter()
	{
		return null;
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public BoidBullet()
		: base()
	{
	}

	public event OnDespawnDelegate OnDespawn;
}
