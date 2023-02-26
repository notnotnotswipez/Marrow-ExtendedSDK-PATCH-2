using System.Runtime.InteropServices;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	public struct MathPlane
	{
		private Vector3 normal;

		private Vector3 origin;

		private float distance;

		public float Distance
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Vector3 Normal
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Origin
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public MathPlane(Vector3 inNormal, Vector3 inPoint)
		{
			this.distance = default(float);
			this.origin = default(Vector3);
			this.normal = default(Vector3);
		}

		public MathPlane(Vector3 inNormal, float d)
		{
			this.distance = default(float);
			this.origin = default(Vector3);
			this.normal = default(Vector3);
		}

		public MathPlane(Vector3 a, Vector3 b, Vector3 c)
		{
			this.distance = default(float);
			this.origin = default(Vector3);
			this.normal = default(Vector3);
		}

		public float GetDistanceToPoint(Vector3 inPt)
		{
			return default(float);
		}

		public bool GetSide(Vector3 inPt)
		{
			return default(bool);
		}

		public bool Raycast(Ray ray, [Out] float enter)
		{
			return default(bool);
		}

		public bool SameSide(Vector3 inPt0, Vector3 inPt1)
		{
			return default(bool);
		}

		public void Set3Points(Vector3 a, Vector3 b, Vector3 c)
		{
		}

		public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint)
		{
		}

		public bool Intersection(Ray ray, [Out] Vector3 point)
		{
			return default(bool);
		}

		public float StretchFactor(Ray ray)
		{
			return default(float);
		}

		public static MathPlane Transform(MathPlane plane, Transform transform)
		{
			return default(MathPlane);
		}

		internal static bool FloatEquals(float a, float b)
		{
			return default(bool);
		}
	}
}
