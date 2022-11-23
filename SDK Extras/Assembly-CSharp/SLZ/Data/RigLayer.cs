using System;
using System.Runtime.CompilerServices;
using SLZ.Rig;
using UnityEngine.Serialization;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public class RigLayer : IRigLayer
	{
		[SerializeField]
		[FormerlySerializedAs("rig")]
		private Rig m_Rig;

		[SerializeField]
		[FormerlySerializedAs("active")]
		private bool m_Active;

		private IRigConstraint[] m_Constraints;

		private IAnimationJob[] m_Jobs;

		public bool active
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string name
		{
			get
			{
				return null;
			}
		}

		public Rig rig { get; }

		public IRigConstraint[] constraints
		{
			get
			{
				return null;
			}
		}

		public IAnimationJob[] jobs
		{
			get
			{
				return null;
			}
		}

		public bool isInitialized { get; private set; }

		public RigLayer(Rig rig, bool active = true)
			: base()
		{
		}

		public bool Initialize(Animator animator)
		{
			return default(bool);
		}

		public void Update()
		{
		}

		public void Reset()
		{
		}

		public bool IsValid()
		{
			return default(bool);
		}
	}
}
