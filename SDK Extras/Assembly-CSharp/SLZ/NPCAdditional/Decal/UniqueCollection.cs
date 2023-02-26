using System.Collections;
using System.Collections.Generic;

namespace ch.sycoforge.Decal
{
	internal class UniqueCollection<T> : ICollection<T>, IEnumerable<T>, IEnumerable
	{
		private Dictionary<T, bool> _innerDictionary;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		void ICollection<T>.Add(T item)
		{
		}

		private void AddInternal(T item)
		{
		}

		public bool Add(T item)
		{
			return default(bool);
		}

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return default(bool);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public bool Remove(T item)
		{
			return default(bool);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public UniqueCollection()
			: base()
		{
		}
	}
}
