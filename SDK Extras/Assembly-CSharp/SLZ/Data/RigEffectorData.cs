using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public class RigEffectorData
	{
		[Serializable]
		public struct Style
		{
			public Mesh shape;

			public Color color;

			public float size;

			public Vector3 position;

			public Vector3 rotation;
		}

		[SerializeField]
		private Transform m_Transform;

		[SerializeField]
		private Style m_Style;

		[SerializeField]
		private bool m_Visible;

		public Transform transform
		{
			get
			{
				return null;
			}
		}

		public Style style
		{
			get
			{
				return default(Style);
			}
		}

		public bool visible
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public void Initialize(Transform transform, Style style)
		{
		}

		public RigEffectorData()
			: base()
		{
		}
	}
}
