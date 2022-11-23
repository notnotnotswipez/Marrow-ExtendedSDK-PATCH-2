using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Marrow_ExtendedSDK.StubClasses;
using PuppetMasta;
using SLZ.AI;
using UnityEngine;

public class BoidController : MonoBehaviour
{
	[Header("Reward Switches")]
	public bool use_passive_penalty;

	public bool use_radius_reward;

	public bool use_movement_loss;

	public bool use_ray_loss;

	public bool use_cohesion_loss;

	public bool use_alignment_loss;

	public bool use_neighbor_loss;

	public bool use_vel_loss;

	public BehaviourBoidAgent_SlicedInference agent;

	public Transform boidBall;

	public Rigidbody _rb;

	public float max_accel;

	public float max_speed;

	public float min_speed;

	public float rotation_slerp_mod;

	public bool log_losses;

	public bool alwaysForward;

	public Vector3 avg_pos;

	public Vector3 avg_alignment;

	public Vector3[] boidPositions;

	public float agentCollisionLoss;

	public float nonAgentCollisionLoss;

	public float bulletCollisionLoss;

	public float cohesion_loss_mod;

	public float personal_space_mod;

	public float alignment_loss_mod;

	public float avgvel_loss_mod;

	public float separation_loss_mod;

	public float neighbor_reward_mod;

	public float move_loss_mod;

	public float reflect_mod;

	public float out_of_radius_mod;

	public float in_radius_mod;

	public bool use_out_penalty;

	public bool out_penalty_on_attempt;

	public bool attempt_started;

	public float rayBumperMod;

	private float previous_speed;

	[HideInInspector]
	public BoidBallManager boidBallMngr;

	public float ray_length;

	public int rayMask;

	public int agentMask;

	public float max_lim;

	public float min_lim;

	public float min_prox_radius;

	public float goal_radius;

	public BoidSensor boidSensor;

	private RaycastHit hit;

	private bool collision_lockout;

	[HideInInspector]
	public Vector3 normalized_destination;

	public Vector3 normalized_position;

	public bool disableMove;

	public bool zeroVelOnAction;

	public bool useSpoolUp;

	private float targetAngle;

	private Vector3 targetAxis;

	private Quaternion deltaQuat;

	private bool chargeRoutine;

	public float chargeForce;

	public float chargeRotateForce;

	public float chargeSpoolForce;

	public float chargeRotateDampenFactor;

	public bool debugCharge;

	public bool charging;

	public bool launch;

	public float chargeTime;

	private float postLaunchCooldown;

	public float postLaunchTime;

	public GameObject chargeTarget;

	public BoidBumper bumpers;

	private RaycastHit[] rayLossResults;

	private float norm_dist;

	private Vector3 norm_ball;

	private Vector3 norm_boid;

	private Vector3 ball_hit_vec;

	public bool debugInput;

	public float collisionStayTimer;

	public float collisionStayCur;

	private int waypointInd;

	private TriggerRefProxy tempTrp;

	public void Reactivate()
	{
	}

	private float MinMaxNorm(float val, float max, float min)
	{
		return default(float);
	}

	private void OnDrawGizmos()
	{
	}

	public float RewardLoop(Agent agent, ActionSegment<int> actions)
	{
		return default(float);
	}

	public float PassivePenalty(int MaxStep)
	{
		return default(float);
	}

	public float RadiusReward()
	{
		return default(float);
	}

	public float BoidAlgLoss()
	{
		return default(float);
	}

	public float NeighborReward()
	{
		return default(float);
	}

	public float CohesionLoss()
	{
		return default(float);
	}

	public float AlignmentLoss()
	{
		return default(float);
	}

	public float AvgVelLoss()
	{
		return default(float);
	}

	public float PersonalSpaceLoss()
	{
		return default(float);
	}

	public float ProximityLoss()
	{
		return default(float);
	}

	public float MovementLoss(int moveVal)
	{
		return default(float);
	}

	public float RayLoss()
	{
		return default(float);
	}

	public float InVolumeLoss()
	{
		return default(float);
	}

	public Vector3 ProximityDelta()
	{
		return default(Vector3);
	}

	public Vector3 BallHitProximityDelta()
	{
		return default(Vector3);
	}

	public float HandleObsRay()
	{
		return default(float);
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void OnCollisionEnter(Collision collision)
	{
	}

	public void OnCollisionStay(Collision collision)
	{
	}

	public void MoveAgent(float[] act)
	{
	}

	internal void SlowMoveVel(int dirToGo, int pitch, int roll, int yaw)
	{
	}

	public void Move(int dirToGo, int pitch, int roll, int yaw)
	{
	}

	private IEnumerator ChargeShot()
	{
		return null;
	}

	public IEnumerator PostLaunchCooldown()
	{
		return null;
	}

	public void KillLaunch()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private IEnumerator WayPointCountdown(TriggerRefProxy trp)
	{
		return null;
	}

	private void SeekWaypoint()
	{
	}

	public BoidController()
		: base()
	{
	}

	public event Action OnAgentCollision;

	public event Action OnNonAgentCollision;

	public event Action OnBulletCollision;
}
