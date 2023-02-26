using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal
{
	[Serializable]
	[ExecuteInEditMode]
	public class EasyDecal : DecalBase
	{
		public const int MaxQuality = 6;

		internal const string CHILD_NAME = "PROC_PLANE";

		internal const string SKINNED_CHILD_NAME = "SKINNED_PROC_PLANE";

		private static Camera renderCamera;

		public LayerMask Mask;

		private int id;

		internal bool evenID;

		private Action<EasyDecal> OnFadedOut_;

		private Action<EasyDecal> OnFadedIn_;

		private Action<EasyDecal> OnFadeOutStarted_;

		private Action<EasyDecal, Mesh> OnProjectionFinished_;

		private Action<EasyDecal> OnAtlasIndexChanged_;

		private Action<EasyDecal> OnSourceChanged_;

		[SerializeField]
		[HideInInspector]
		private GameObject projectionTarget;

		[SerializeField]
		[HideInInspector]
		private ProjectionMode mode;

		[HideInInspector]
		[SerializeField]
		private SourceMode source;

		[HideInInspector]
		[SerializeField]
		private AspectMode aspectCorrectionMode;

		[HideInInspector]
		[SerializeField]
		private LookupMode recursiveMode;

		[SerializeField]
		[HideInInspector]
		private SkinQuality skinningQuality;

		[HideInInspector]
		[SerializeField]
		internal Material material;

		[SerializeField]
		[HideInInspector]
		private DecalTextureAtlas atlas;

		[HideInInspector]
		[SerializeField]
		private int atlasRegionIndex;

		[HideInInspector]
		[SerializeField]
		private float maxDistance;

		[HideInInspector]
		[SerializeField]
		private float projectionDistance;

		[HideInInspector]
		[SerializeField]
		private bool smoothNormals;

		[HideInInspector]
		[SerializeField]
		private float normalSmoothFactor;

		[HideInInspector]
		[SerializeField]
		private float normalSmoothThreshold;

		[SerializeField]
		[HideInInspector]
		internal int resolution;

		[HideInInspector]
		[SerializeField]
		private bool multiMeshEnabled;

		[SerializeField]
		[HideInInspector]
		private bool cullInvisible;

		[HideInInspector]
		[SerializeField]
		private bool cullUnreachable;

		[SerializeField]
		[HideInInspector]
		private bool showVertices;

		[SerializeField]
		[HideInInspector]
		private bool showDir;

		[HideInInspector]
		[SerializeField]
		private bool showNormals;

		[SerializeField]
		[HideInInspector]
		private bool enableVertexColorFade;

		[HideInInspector]
		[SerializeField]
		private bool onlyColliders;

		[SerializeField]
		[FormerlySerializedAs("tangents")]
		[HideInInspector]
		private bool calculateTangents;

		[HideInInspector]
		[SerializeField]
		private bool calculateNormals;

		[SerializeField]
		[HideInInspector]
		private MeshChannelMode normalChannelMode;

		[HideInInspector]
		[SerializeField]
		private MeshChannelMode tangentChannelMode;

		[SerializeField]
		[HideInInspector]
		private bool recursiceLookup;

		[HideInInspector]
		[SerializeField]
		private bool randomIndexEnabled;

		[HideInInspector]
		[SerializeField]
		private int recursiceLookupSteps;

		[HideInInspector]
		[SerializeField]
		private bool autoDestroy;

		[HideInInspector]
		[SerializeField]
		private OpacityMode opacityMode;

		[HideInInspector]
		[SerializeField]
		private bool fadeOnly;

		[SerializeField]
		[HideInInspector]
		private bool useLightProbes;

		[HideInInspector]
		[SerializeField]
		private float lifetime;

		[HideInInspector]
		[SerializeField]
		private float fadeoutTime;

		[HideInInspector]
		[SerializeField]
		private float fadeinTime;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve fadeoutCurve;

		[HideInInspector]
		[SerializeField]
		private AnimationCurve fadeinCurve;

		[SerializeField]
		[HideInInspector]
		private float surfaceRotation;

		[HideInInspector]
		[SerializeField]
		private int quality;

		private GameObject receiver;

		private GameObject meshContainer;

		private GameObject skinnedMeshContainer;

		private List<IMeshProcessor> meshProcessors;

		private float creationTime;

		private float alpha;

		private int creationFrameNumber;

		private int bakeInFrameNumber;

		private bool needUVRecreation;

		private bool needGeometryRecreation;

		[HideInInspector]
		[SerializeField]
		private Mesh sharedMesh;

		[SerializeField]
		[HideInInspector]
		private int instanceID;

		internal bool projectBake;

		public static StaticProxyCollection ProxyCollection;

		public static bool HideMesh;

		public static InstantiationDelegate Instantiation;

		public static Camera RenderCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ID
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}

		public SkinQuality SkinningQuality
		{
			get
			{
				return default(SkinQuality);
			}
			set
			{
			}
		}

		public Mesh SharedMesh
		{
			get
			{
				return null;
			}
		}

		public bool IsVisible
		{
			get
			{
				return default(bool);
			}
		}

		public int Quality
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool MultiMeshEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool CullInvisibles
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool CullUnreachable
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public GameObject Receiver
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public bool CalculateTangents
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public MeshChannelMode TangentChannelMode
		{
			get
			{
				return default(MeshChannelMode);
			}
			set
			{
			}
		}

		public bool CalculateNormals
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public MeshChannelMode NormalChannelMode
		{
			get
			{
				return default(MeshChannelMode);
			}
			set
			{
			}
		}

		public bool ShowDir
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool ShowVertices
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool ShowNormals
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float MaxDistance
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ProjectionDistance
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool SmoothNormals
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float NormalSmoothFactor
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float NormalSmoothThreshold
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool DontDestroy
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool FadeOut
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public OpacityMode OpacityMode
		{
			get
			{
				return default(OpacityMode);
			}
			set
			{
			}
		}

		public float Lifetime
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float RemainingLifetime
		{
			get
			{
				return default(float);
			}
		}

		public float CurrentFadeoutTime { get; private set; }

		public float FadeoutTime
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float FadeinTime
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public AnimationCurve FadeoutCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 InverseProjectionDirection { get; private set; }

		public float SurfaceRotation
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Material DecalMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DecalTextureAtlas Atlas
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int AtlasRegionIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public GameObject MeshContainer
		{
			get
			{
				return null;
			}
		}

		public ProjectionMode Mode
		{
			get
			{
				return default(ProjectionMode);
			}
			set
			{
			}
		}

		public SourceMode Source
		{
			get
			{
				return default(SourceMode);
			}
			set
			{
			}
		}

		public AspectMode AspectCorrectionMode
		{
			get
			{
				return default(AspectMode);
			}
			set
			{
			}
		}

		public LookupMode RecursiveMode
		{
			get
			{
				return default(LookupMode);
			}
			set
			{
			}
		}

		public float Alpha
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[Obsolete("Use EasyDecal.IsFading instead.")]
		public bool IsFadingOut
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsFading
		{
			get
			{
				return default(bool);
			}
		}

		public bool OnlyColliders
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool EnableVertexColorBleed
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool RecursiveLookup
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool RandomIndexEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int RecursiveLookupSteps
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public List<IMeshProcessor> MeshProcessors
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseLightProbes
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public GameObject ProjectionTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action<EasyDecal> OnFadedOut
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal> OnFadedIn
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal> OnFadeOutStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal, Mesh> OnProjectionFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal> OnAtlasIndexChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal> OnSourceChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal void CalculateResolutionFromQuality(int quality)
		{
		}

		public void Reset()
		{
		}

		public void Reset(bool unbake)
		{
		}

		public void Reset(bool unbake, bool recreate)
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void StartFade()
		{
		}

		public void CancelFade()
		{
		}

		public void SelectRandom()
		{
		}

		public void CorrectAspect()
		{
		}

		private void StartFadeOut()
		{
		}

		public void StartFade(FadingMode mode = FadingMode.Out)
		{
		}

		private IEnumerator ProcessFadeOut()
		{
			return null;
		}

		private IEnumerator ProcessFadeIn()
		{
			return null;
		}

		public Vector3[] GetBoundingVertices()
		{
			return null;
		}

		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		protected virtual void OnDrawGizmos()
		{
		}

		public void OnDrawGizmosSelected()
		{
		}

		protected override void Update()
		{
		}

		protected override void Initialize()
		{
		}

		protected override void InitalizeProjector()
		{
		}

		private void Log(string msg)
		{
		}

		protected override void OnChangedTechnique()
		{
		}

		protected virtual void OnChangedAtlasIndex()
		{
		}

		protected virtual void OnChangedSource()
		{
		}

		protected virtual void OnChangedAlpha()
		{
		}

		protected override void OnChangedBakeStatus()
		{
		}

		protected override void AskForGeometryRecreation()
		{
		}

		protected override void AskForUVRecreation()
		{
		}

		private void CreateDecalGameObject()
		{
		}

		private void SetChildTransform(GameObject child)
		{
		}

		private void ResetMesh()
		{
		}

		private Mesh FindSharedMesh()
		{
			return null;
		}

		private GameObject Search(string name)
		{
			return null;
		}

		internal void AddDynamicMesh(DynamicMesh dynamicMesh, bool isStatic = false)
		{
		}

		private void ConvertAndAssign(DynamicMesh dynamicMesh, bool forceRecreation)
		{
		}

		private void AssignSharedMesh(Mesh mesh)
		{
		}

		private void PostProcessMesh(DynamicMesh mesh)
		{
		}

		public void PostProcessMesh(Mesh mesh)
		{
		}

		internal void TransformUV(DynamicMesh dynamicMesh)
		{
		}

		private void DrawMeshGeometryGizmos(Vector3[] vertices, Vector3[] normals)
		{
		}

		private void ResetPlanes()
		{
		}

		protected void UpdateDecal()
		{
		}

		[Obsolete("Use LateBake() instead.")]
		protected void ProjectBake()
		{
		}

		public void LateUnbake()
		{
		}

		public void LateBake()
		{
		}

		public void LateBake(uint frames)
		{
		}

		internal Color GetFadeoutColor()
		{
			return default(Color);
		}

		private void CallOnProjectionFinished(Mesh mesh)
		{
		}

		private void CallOnFadeOutStarted()
		{
		}

		private void CallOnFadedOut()
		{
		}

		private void CallOnFadedIn()
		{
		}

		private void CallOnAtlasIndexChanged()
		{
		}

		private void CallOnSourceChanged()
		{
		}

		private void CallOnAlphaChanged()
		{
		}

		public static EasyDecal Clone(EasyDecal decal)
		{
			return null;
		}

		public static void CopyProperties(EasyDecal from, EasyDecal to)
		{
		}

		public static void SetStaticProxyCollection(StaticProxyCollection proxyCollection)
		{
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 forward, Vector3 up, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Quaternion rotation, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 normal, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 normal, float rotation, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 normal, float rotation, Vector3 scale, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Quaternion rotation, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Vector3 normal, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Vector3 normal, float rotation, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Ray ray, bool instantiate = true)
		{
			return null;
		}

		private static EasyDecal ProjectInternal(GameObject decalPrefab, GameObject parent, Vector3 position, Quaternion rotation, Vector3 scale, bool instantiate)
		{
			return null;
		}

		private static List<EasyDecal> SearchChildren(Transform parent)
		{
			return null;
		}

		private static bool ContainsLayer(LayerMask mask, int layer)
		{
			return default(bool);
		}

		public EasyDecal()
			: base()
		{
		}
	}
}
