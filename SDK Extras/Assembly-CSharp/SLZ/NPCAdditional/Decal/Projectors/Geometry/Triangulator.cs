using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	public class Triangulator
	{
		private List<Vector3> m_points;

		public Triangulator(List<Vector3> points)
			: base()
		{
		}

		public int[] Triangulate()
		{
			return null;
		}

		private float Area()
		{
			return default(float);
		}

		private bool Snip(int u, int v, int w, int n, int[] V)
		{
			return default(bool);
		}

		private bool InsideTriangle(Vector2 A, Vector2 B, Vector2 C, Vector2 P)
		{
			return default(bool);
		}
	}
}
