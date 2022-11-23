using System;
using RootMotion;
using UnityEngine;

namespace PuppetMasta
{
	[CreateAssetMenu(fileName = "PuppetMaster Humanoid Config", menuName = "PuppetMaster/Humanoid Config", order = 1)]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		public class HumanoidMuscle
		{
			[HideInInspector]
			[SerializeField]
			public string name;

			public HumanBodyBones bone;

			public Muscle.Props props;

			public HumanoidMuscle()
				: base()
			{
			}
		}
		
		public PuppetMaster.State state;

		public PuppetMaster.StateSettings stateSettings;

		public PuppetMaster.Mode mode;

		public float blendTime;

		public bool fixTargetTransforms;

		public int solverIterationCount;

		public bool visualizeTargetPose;

		[Range(0f, 1f)]
		public float mappingWeight;

		[Range(0f, 1f)]
		public float muscleWeight;
		
		public float muscleSpring;

		public float muscleDamper;

		public bool updateJointAnchors;

		public bool angularLimits;

		public bool internalCollisions;
		
		public HumanoidMuscle[] muscles;

		public void ApplyTo(PuppetMaster p)
		{
		}

		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		public PuppetMasterHumanoidConfig()
			: base()
		{
		}
	}
}
