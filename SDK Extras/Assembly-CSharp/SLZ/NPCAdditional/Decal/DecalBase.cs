using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using ch.sycoforge.Decal.Projectors;

namespace ch.sycoforge.Decal
{
	public abstract class DecalBase : MonoBehaviour
	{
		private const string RootName = "[Decal Root]";

		private OrientationChangedHandler OnOrientationChanged_;

		private TechniqueChangedHandler OnTechniqueChangedHandler_;

		private DeferredFlagsChangedHandler OnDeferredFlagsChanged_;

		private BakeStatusChangedHandler OnBakeStatusChanged_;

		private Action<DecalBase> OnDestroyed_;

		private Vector3 lastPosition;

		private Vector3 lastScale;

		private Quaternion lastRotation;

		[SerializeField]
		[HideInInspector]
		protected bool baked;

		[SerializeField]
		[HideInInspector]
		protected bool bakeOnAwake;

		[HideInInspector]
		[SerializeField]
		private bool flipNormals;

		[HideInInspector]
		[SerializeField]
		private bool backfaceCulling;

		[HideInInspector]
		[SerializeField]
		private float distance;

		[HideInInspector]
		[SerializeField]
		private float angleConstraint;

		[SerializeField]
		[HideInInspector]
		protected ProjectionTechnique technique;

		[SerializeField]
		[HideInInspector]
		protected ch.sycoforge.Decal.Projectors.Projector projector;

		[SerializeField]
		[HideInInspector]
		private DeferredFlags deferredFlags;

		[SerializeField]
		[HideInInspector]
		private ProjectorInclusion inclusion;

		[SerializeField]
		[HideInInspector]
		private TransformObserver transformObserver;

		private Bounds bounds;

		private ProjectionTechnique lastTechnique;

		private DeferredFlags lastDeferredFlags;

		[HideInInspector]
		[SerializeField]
		private bool needsDynamicGeometry;

		private static GameObject combinedRoot;

		private static DecalRoot decalRoot;

		private static GameObject CombinedRoot
		{
			get
			{
				return null;
			}
		}

		public static DecalRoot DecalRoot
		{
			get
			{
				return null;
			}
		}

		public bool Baked
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool BakeOnAwake
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool FlipNormals
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool BackfaceCulling
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Matrix4x4 WorldToLocalMatrix { get; protected set; }

		public Matrix4x4 LocalToWorldMatrix { get; protected set; }

		public Transform CachedTransform { get; protected set; }

		public Quaternion Rotation { get; private set; }

		public Vector3 Position { get; private set; }

		public Vector3 Scale { get; private set; }

		public float Distance
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float AngleConstraint
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public ProjectionTechnique Technique
		{
			get
			{
				return default(ProjectionTechnique);
			}
			set
			{
			}
		}

		public ProjectorInclusion Inclusion
		{
			get
			{
				return default(ProjectorInclusion);
			}
			set
			{
			}
		}

		public DeferredFlags DeferredFlags
		{
			get
			{
				return default(DeferredFlags);
			}
			set
			{
			}
		}

		public Renderer DecalRenderer { get; set; }

		public SkinnedMeshRenderer SkinnedDecalRenderer
		{
			get
			{
				return null;
			}
		}

		public MeshFilter MeshFilter { get; protected set; }

		public ch.sycoforge.Decal.Projectors.Projector Projector
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool NeedsDynamicGeometry
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public event OrientationChangedHandler OnOrientationChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal event TechniqueChangedHandler OnTechniqueChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal event DeferredFlagsChangedHandler OnDeferredFlagsChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal event BakeStatusChangedHandler OnBakeStatusChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal event Action<DecalBase> OnDestroyed
		{
			add
			{
			}
			remove
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void Initialize()
		{
		}

		protected virtual void OnChangedTechnique()
		{
		}

		protected virtual void OnChangedDeferredFlags()
		{
		}

		protected virtual void OnChangedOrientation()
		{
		}

		protected virtual void OnChangedBakeStatus()
		{
		}

		protected abstract void InitalizeProjector();

		protected void CallOnPropertyChanged(object oldValue, object newValue)
		{
		}

		protected virtual void AskForUVRecreation()
		{
		}

		protected virtual void AskForGeometryRecreation()
		{
		}

		public Bounds Bounds()
		{
			return default(Bounds);
		}

		private void CheckTechniqueChange()
		{
		}

		private void CheckDeferredFlagsChange()
		{
		}

		private Bounds CalculateBounds()
		{
			return default(Bounds);
		}

		private void SetLastTransforms()
		{
		}

		private void CallOnOrientationChanged(OrientationChange change)
		{
		}

		private void CallOnTechniqueChanged(ProjectionTechnique last, ProjectionTechnique curr)
		{
		}

		private void CallOnDeferredFlagsChanged(DeferredFlags last, DeferredFlags curr)
		{
		}

		private void CallOnDestroyed()
		{
		}

		private void CallOnBakeStatusChanged()
		{
		}

		public static void TryInitializeRoot()
		{
		}

		public DecalBase()
			: base()
		{
		}
	}
}
