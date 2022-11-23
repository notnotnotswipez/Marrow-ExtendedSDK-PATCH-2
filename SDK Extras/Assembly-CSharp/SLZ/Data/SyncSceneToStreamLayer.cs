using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Animations.Rigging
{
	internal class SyncSceneToStreamLayer
	{
		public IAnimationJob job;

		private List<int> m_RigIndices;

		public bool isInitialized { get; private set; }

		public bool Initialize(Animator animator, IList<IRigLayer> layers)
		{
			return default(bool);
		}

		public void Update(IList<IRigLayer> layers)
		{
		}

		public void Reset()
		{
		}

		public bool IsValid()
		{
			return default(bool);
		}

		public SyncSceneToStreamLayer()
			: base()
		{
		}
	}
}
