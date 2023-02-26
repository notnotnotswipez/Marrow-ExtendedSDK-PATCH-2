using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace MK.Glow.URP
{
	public class MKGlowRendererFeature : ScriptableRendererFeature
	{
		public class MKGlowRenderPass : ScriptableRenderPass
		{
			private MKGlow _mKGlowVolumeComponent;

			internal Effect effect;

			internal ScriptableRenderer scriptableRenderer;

			private RenderTarget sourceRenderTarget;

			private RenderTarget destinationRenderTarget;

			private CameraDataURP _cameraData;

			private SettingsURP _settingsURP;

			private RenderTextureDescriptor _sourceDescriptor;

			private readonly int _rendererBufferID;

			private readonly string _profilerName;

			private MKGlow mKGlowVolumeComponent
			{
				get
				{
					return null;
				}
			}

			public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
			}

			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
				throw new System.NotImplementedException();
			}

			public MKGlowRenderPass()
				: base()
			{
			}
		}

		private MKGlowRenderPass _mkGlowRenderPass;

		private readonly string _componentName;

		public override void Create()
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			throw new System.NotImplementedException();
		}

		public void Disable()
		{
		}

		private void OnDisable()
		{
		}

		public MKGlowRendererFeature()
			: base()
		{
		}
	}
}
