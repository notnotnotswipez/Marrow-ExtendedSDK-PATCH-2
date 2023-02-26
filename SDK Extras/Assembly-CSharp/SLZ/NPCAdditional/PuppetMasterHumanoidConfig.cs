using System;
using UnityEngine;

namespace PuppetMasta
{
	[CreateAssetMenu(fileName = "PuppetMaster Humanoid Config", menuName = "PuppetMaster/Humanoid Config", order = 1)]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		public class HumanoidMuscle
		{
			[SerializeField]
			[HideInInspector]
			public string name;

			public HumanBodyBones bone;

			//public Muscle.Props props;

			public HumanoidMuscle()
				: base()
			{
			}
		}

		//[LargeHeader("Simulation")]
		public PuppetMaster.State state;

		public PuppetMaster.StateSettings stateSettings;

		public PuppetMaster.Mode mode;

		public float blendTime;

		public bool fixTargetTransforms;

		public int solverIterationCount;

		public bool visualizeTargetPose;

		//[LargeHeader("Master Weights")]
		[Range(0f, 1f)]
		public float mappingWeight;

		[Range(0f, 1f)]
		public float muscleWeight;

		//[LargeHeader("Joint and Muscle Settings")]
		public float muscleSpring;

		public float muscleDamper;

		public bool updateJointAnchors;

		public bool angularLimits;

		public bool internalCollisions;

		//[LargeHeader("Individual Muscle Settings")]
		public HumanoidMuscle[] muscles;

		public void ApplyTo(PuppetMaster p)
		{
		}

		public PuppetMasterHumanoidConfig()
			: base()
		{
		}
	}
}
