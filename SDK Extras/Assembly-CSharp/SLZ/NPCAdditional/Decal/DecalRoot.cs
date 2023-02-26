using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace ch.sycoforge.Decal
{
	[ExecuteInEditMode]
	[AddComponentMenu(null)]
	public class DecalRoot : DecalBase
	{
		private const string DIFFUSEBUFFER_RT0 = "_DiffuseAOBuffer";

		private const string SPECSMOOTHBUFFER_RT1 = "_SpecSmoothBuffer";

		private const string NORMALBUFFER_RT2 = "_NormalBuffer";

		private const string LIGTHINGEMISSION_RT2 = "_LightingEmissionBuffer";

		private const string SCENECAMERA = "SceneCamera";

		private const FilterMode filterMode = FilterMode.Point;

		private const string CMDBUFFER = "Easy Decals";

		private Dictionary<Camera, CommandBuffer> cameraBuffers;

		private Dictionary<Camera, RenderCamera> cameras;

		private readonly CameraEvent evt;

		private int diffuseBufferID;

		private int specSmoothBufferID;

		private int normalsBufferID;

		private int ligthingEmissionBufferID;

		private Camera SceneCamera;

		[CompilerGenerated]
		private static Predicate<CommandBuffer> CS_0024_003C_003E9__CachedAnonymousMethodDelegate2;

		[CompilerGenerated]
		private static Predicate<CommandBuffer> CS_0024_003C_003E9__CachedAnonymousMethodDelegate3;

		protected override void Initialize()
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

		private void OnRenderCamera(Camera camera)
		{
		}

		private void OnRenderObject()
		{
		}

		private void OnWillRenderObject()
		{
		}

		private void RenderDecals(RenderCamera cam)
		{
		}

		private bool IsSceneCamera(Camera camera)
		{
			return default(bool);
		}

		protected override void InitalizeProjector()
		{
		}

		private CommandBuffer GetBuffer(Camera cam)
		{
			return null;
		}

		public DecalRoot()
			: base()
		{
		}
	}
}
