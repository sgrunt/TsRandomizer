﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace TsRanodmizer
{
	class LookupDictionairy<TLookup, TValue> : IEnumerable<TValue>
	{
		readonly Func<TValue, TLookup> keySelector;
		readonly Dictionary<TLookup, TValue> lookupTable;

		public LookupDictionairy(Func<TValue, TLookup> keySelector) : this(0, keySelector)
		{
			this.keySelector = keySelector;
		}

		public LookupDictionairy(int capacity, Func<TValue, TLookup> keySelector)
		{
			lookupTable = new Dictionary<TLookup, TValue>(capacity);
			this.keySelector = keySelector;
		}

		public TValue this[TLookup key] => lookupTable[key];
		public TValue this[TValue value] => value;

		public bool TryGetValue(TLookup key, out TValue value)
		{
			return lookupTable.TryGetValue(key, out value);
		}

		public IEnumerator<TValue> GetEnumerator()
		{
			return ((IEnumerable<TValue>)lookupTable.Values).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return lookupTable.Values.GetEnumerator();
		}

		public void Add(TValue value)
		{
			lookupTable.Add(keySelector(value), value);
		}

		public bool Contains(TLookup key)
		{
			return lookupTable.ContainsKey(key);
		}
	}
}