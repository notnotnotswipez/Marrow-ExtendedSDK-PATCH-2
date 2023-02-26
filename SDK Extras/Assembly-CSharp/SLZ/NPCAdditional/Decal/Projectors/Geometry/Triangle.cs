using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	public struct Triangle
	{
		public int TriangleIndex;

		public int IndexA;

		public int IndexB;

		public int IndexC;

		public int this[int index]
		{
			get
			{
				return default(int);
			}
		}

		public Triangle(int triangleIndex, int indexA, int indexB, int indexC)
		{
			this.IndexC = default(int);
			this.IndexB = default(int);
			this.IndexA = default(int);
			this.TriangleIndex = default(int);
		}

		public bool IsValid(IList<Vector3> vertices, float value)
		{
			return default(bool);
		}
	}
}
