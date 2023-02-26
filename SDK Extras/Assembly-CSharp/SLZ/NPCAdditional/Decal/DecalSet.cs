using System.Collections;
using System.Collections.Generic;

namespace ch.sycoforge.Decal
{
	internal class DecalSet : IEnumerable<EasyDecal>, IEnumerable
	{
		private HashSet<EasyDecal> sceneDecals;

		private Dictionary<ProjectionTechnique, HashSet<EasyDecal>> techGroupedDecals;

		private Dictionary<ProjectionTechnique, Dictionary<DeferredFlags, HashSet<EasyDecal>>> flagsGroupedDecals;

		private HashSet<EasyDecal> empty;

		private ProjectionTechniqueComparer ptc;

		private DeferredFlagsComparer dfc;

		private static int nextID;

		public IEnumerable<EasyDecal> SceneDecals
		{
			get
			{
				return null;
			}
		}

		public IEnumerable<EasyDecal> DeferredDecals
		{
			get
			{
				return null;
			}
		}

		internal DecalSet()
			: base()
		{
		}

		public HashSet<EasyDecal> GetDecals(ProjectionTechnique technique)
		{
			return null;
		}

		public HashSet<EasyDecal> GetDecals(ProjectionTechnique technique, DeferredFlags flags)
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Add(EasyDecal decal)
		{
		}

		public void Remove(EasyDecal decal)
		{
		}

		private void decal_OnDeactivated(DecalBase obj)
		{
		}

		private void decal_OnDeferredFlagsChanged(DecalBase decal, DeferredFlags lastFlags, DeferredFlags currFlags)
		{
		}

		private void decal_OnTechniqueChanged(DecalBase decal, ProjectionTechnique lastTech, ProjectionTechnique currTech)
		{
		}

		public HashSet<EasyDecal> GetDeferredDecals(DeferredFlags flags)
		{
			return null;
		}

		public IEnumerator<EasyDecal> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private void Initialize()
		{
		}
	}
}
