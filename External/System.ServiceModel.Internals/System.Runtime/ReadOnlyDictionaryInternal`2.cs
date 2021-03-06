using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Runtime
{
	[Serializable]
	internal class ReadOnlyDictionaryInternal<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		private IDictionary<TKey, TValue> dictionary;

		public int Count
		{
			get
			{
				return this.dictionary.Count;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		public TValue this[TKey key]
		{
			get
			{
				return this.dictionary[key];
			}
			set
			{
				throw Fx.Exception.AsError(this.CreateReadOnlyException());
			}
		}

		public ICollection<TKey> Keys
		{
			get
			{
				return this.dictionary.Keys;
			}
		}

		public ICollection<TValue> Values
		{
			get
			{
				return this.dictionary.Values;
			}
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public ReadOnlyDictionaryInternal(IDictionary<TKey, TValue> dictionary)
		{
			this.dictionary = dictionary;
		}

		public void Add(TKey key, TValue value)
		{
			throw Fx.Exception.AsError(this.CreateReadOnlyException());
		}

		public void Add(KeyValuePair<TKey, TValue> item)
		{
			throw Fx.Exception.AsError(this.CreateReadOnlyException());
		}

		public void Clear()
		{
			throw Fx.Exception.AsError(this.CreateReadOnlyException());
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return this.dictionary.Contains(item);
		}

		public bool ContainsKey(TKey key)
		{
			return this.dictionary.ContainsKey(key);
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			this.dictionary.CopyTo(array, arrayIndex);
		}

		public static IDictionary<TKey, TValue> Create(IDictionary<TKey, TValue> dictionary)
		{
			if (!dictionary.IsReadOnly)
			{
				return new ReadOnlyDictionaryInternal<TKey, TValue>(dictionary);
			}
			else
			{
				return dictionary;
			}
		}

		private Exception CreateReadOnlyException()
		{
			return new InvalidOperationException(InternalSR.DictionaryIsReadOnly);
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return this.dictionary.GetEnumerator();
		}

		public bool Remove(TKey key)
		{
			throw Fx.Exception.AsError(this.CreateReadOnlyException());
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			throw Fx.Exception.AsError(this.CreateReadOnlyException());
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return this.dictionary.TryGetValue(key, out value);
		}
	}
}