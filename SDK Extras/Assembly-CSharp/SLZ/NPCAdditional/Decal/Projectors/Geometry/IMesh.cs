using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	public interface IMesh
	{
		List<Vector3> Normals { get; }

		List<Vector4> Tangents { get; }

		List<Color> VertexColors { get; }

		List<int> TriangleIndices { get; }

		List<Vector2> UV { get; }

		List<Vector2> UV2 { get; }

		List<Vector3> Vertices { get; }
	}
}
