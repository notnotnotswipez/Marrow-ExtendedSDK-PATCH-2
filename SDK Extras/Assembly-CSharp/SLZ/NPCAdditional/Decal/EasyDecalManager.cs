using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	public static class EasyDecalManager
	{
		public delegate IList<T> SceneFinder<T>();

		public static SceneFinder<CombinedDecalsGroup> SceneGroupsFinder;

		public static SceneFinder<EasyDecal> SceneDecalsFinder;

		public static Action<Mesh, float, float> Unwrapper;

		private static List<CombinedDecalsGroup> combinedSceneDecals;

		private static IDictionary<Material, IList<EasyDecal>> materialGroupedDecals;

		private static IDictionary<DecalTextureAtlas, IList<EasyDecal>> atlasGroupedDecals;

		private static DecalSet decalSet;

		private static List<DecalBufferGroup> flagsBoundDecals;

		public static IEnumerable<EasyDecal> SceneDecals
		{
			get
			{
				return null;
			}
		}

		public static IList<CombinedDecalsGroup> CombinedSceneDecals
		{
			get
			{
				return null;
			}
		}

		public static IDictionary<Material, IList<EasyDecal>> MaterialGroupedDecals
		{
			get
			{
				return null;
			}
		}

		public static IDictionary<DecalTextureAtlas, IList<EasyDecal>> AtlasGroupedDecals
		{
			get
			{
				return null;
			}
		}

		public static IEnumerable<EasyDecal> DeferredDecals
		{
			get
			{
				return null;
			}
		}

		public static HashSet<EasyDecal> GetDecals(ProjectionTechnique technique)
		{
			return null;
		}

		public static HashSet<EasyDecal> GetDecals(ProjectionTechnique technique, DeferredFlags flags)
		{
			return null;
		}

		internal static List<DecalBufferGroup> GetDecalBufferGroups()
		{
			return null;
		}

		public static HashSet<EasyDecal> GetDeferredDecals(DeferredFlags flags)
		{
			return null;
		}

		public static IEnumerable<EasyDecal> GetDeferredDecals()
		{
			return null;
		}

		public static void Add(EasyDecal decal)
		{
		}

		public static void Remove(EasyDecal decal)
		{
		}

		public static void EditorUpdate()
		{
		}

		public static void DeleteSceneDecal(EasyDecal decal)
		{
		}

		public static void CombineAtlasGroup(DecalTextureAtlas atlas, bool setStatic = true)
		{
		}

		public static bool IsCombined(DecalTextureAtlas atlas)
		{
			return default(bool);
		}

		public static void SeparateAtlasGroup(DecalTextureAtlas atlas)
		{
		}

		public static void BakeAll(bool bake)
		{
		}

		public static void Bake(IEnumerable<EasyDecal> decals, bool bake)
		{
		}

		public static void Activate(IEnumerable<EasyDecal> decals, bool active)
		{
		}

		private static void Initialize()
		{
		}

		public static void Refresh()
		{
		}

		private static void Enrow<T>(T item, EasyDecal decal, IDictionary<T, IList<EasyDecal>> groupedDecals)
		{
		}
	}
}
