using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PuppetMasta;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.SFX;
using UnityEngine;

public class BoidGun : MonoBehaviour
{
	[Header("Gun Specific Section")]
	[Tooltip("Total number of boids that can be out in the scene and amount of ammo")]
	public int maxMagSize;

	private int currentMagSize;

	[Tooltip("Rate at which boids will do the spin attack (boidBehaviour)")]
	public float attackProb;

	[Tooltip("Hand Grip")]
	public Grip triggerGrip;

	[Tooltip("Min amount of time it takes to summon a boid")]
	public float minChargeTime;

	[Tooltip("Max amount of time it takes to summon a boid")]
	public float maxChargeTime;

	[Tooltip("Max Amount of Force that will be applied to boid when shot")]
	public float maxLaunchForce;

	private float currentChargeTime;

	private bool charging;

	public Spawnable boid;

	[Tooltip("Where Spawn VFX and Boid will appear while charging/launching")]
	public GameObject spawnPointObject;

	[Header("Gun Specific Section")]
	public float bulletAliveTime;

	public Rigidbody _rb;

	[Tooltip("VFX that spawn where the boid will appear")]
	[Header("FX Section")]
	public Spawnable chargingVFX;

	[Tooltip("VFX that spawn where the boid will appear after boids been spawned")]
	public Spawnable blastVFX;

	[Tooltip("VFX that spawn where the boid will appear after boids been spawned")]
	public Spawnable despawnVFX;

	[Tooltip("Sound affect for shooting the boid")]
	public GunSFX launchSFX;

	[Tooltip("Sound affect for indicating an empty mag")]
	public GunSFX emptySFX;

	[Tooltip("Sound affect for when charge is initialized")]
	public GunSFX triggerSFX;

	[Tooltip("Sound affect for charging the gun")]
	public GunSFX chargingSFX;

	[Tooltip("Sound affect for powering up gun")]
	public GunSFX powerUpSFX;

	[Tooltip("Sound affect for powering down gun")]
	public GunSFX powerDownSFX;

	[Tooltip("The model manager that this spawner is associated with")]
	[Header("Inference Section")]
	public BarracudaModelManagerMono bmm;

	[Tooltip("Scriptable object that holds model manager/spawner variable and model references")]
	public ModelManagerConfig bmmConfig;

	[Tooltip("The boids that have been spawned and are in the scene")]
	public List<BehaviourBoidAgent_SlicedInference> dispatchedBoidList;

	[Tooltip("Whether to initialize bmm on Start()")]
	public bool bmmInitOnStart;

	private int sliceSizeMin;

	private int sliceSizeMax;

	private bool bmmActive;

	private BehaviourBoidAgent_SlicedInference temp_agent;

	private BoidBullet temp_bullet;

	private GameObject blast;

	private GameObject charge;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTriggerGripAttached(Hand hand)
	{
	}

	private void OnTriggerGripDetached(Hand hand)
	{
	}

	private void OnTriggerGripUpdate(Hand hand)
	{
	}

	private IEnumerator ChargeShot()
	{
		return null;
	}

	private void Fire()
	{
	}

	private void AgentInitialization(GameObject go)
	{
	}

	private void HandleBoidLaunch()
	{
	}

	public void BoidDespawned(BehaviourBoidAgent_SlicedInference boid)
	{
	}

	private void BMMSetup()
	{
	}

	public void CommandDeactivate()
	{
	}

	private void OnDestroy()
	{
	}

	public void WarmStartModelManager()
	{
	}

	public void StartBMM()
	{
	}

	public BoidGun()
		: base()
	{
	}
}
