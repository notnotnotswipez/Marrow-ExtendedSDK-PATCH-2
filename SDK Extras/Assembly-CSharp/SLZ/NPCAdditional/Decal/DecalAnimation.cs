using System;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	public class DecalAnimation : MonoBehaviour
	{
		public int Columns;

		public int Rows;

		public float FPS;

		public bool CorrectTime;

		public TweenType Type;

		public string[] InputTextureNames;

		private int frames;

		private int frameNumber;

		private int direction;

		private float duration;

		private float frameTime;

		private float rowFrac;

		private float colFrac;

		private Vector2 size;

		private Renderer decalRenderer;

		public event Action<DecalAnimation> OnAnimationFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		public virtual void Start()
		{
		}

		private void Initialize()
		{
		}

		protected virtual void RenderFrame()
		{
		}

		public bool IsFinished()
		{
			return default(bool);
		}

		public void Reset()
		{
		}

		protected void SwitchDirection()
		{
		}

		protected void SetTexturesScale(Vector2 size)
		{
		}

		protected void SetTexturesOffsets(Vector2 offset)
		{
		}

		private void CallOnFinished()
		{
		}

		public DecalAnimation()
			: base()
		{
		}
	}
}
