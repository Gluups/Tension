using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tension
{
	class JourList : IBindingList
	{
		public List this[int index] {
			get => throw new NotImplementedException();
			set => throw new NotImplementedException();
		}

		public bool AllowNew => throw new NotImplementedException();

		public bool AllowEdit => throw new NotImplementedException();

		public bool AllowRemove => throw new NotImplementedException();

		public bool SupportsChangeNotification => throw new NotImplementedException();

		public bool SupportsSearching => throw new NotImplementedException();

		public bool SupportsSorting => throw new NotImplementedException();

		public bool IsSorted => throw new NotImplementedException();

		public PropertyDescriptor SortProperty => throw new NotImplementedException();

		public ListSortDirection SortDirection => throw new NotImplementedException();

		public bool IsReadOnly => throw new NotImplementedException();

		public bool IsFixedSize => throw new NotImplementedException();

		public int Count => throw new NotImplementedException();

		public object SyncRoot => throw new NotImplementedException();

		public bool IsSynchronized => throw new NotImplementedException();

		public event ListChangedEventHandler ListChanged;

		public int Add(UnJour value)
		{
			return List.Add(value); 
		}

		public void AddIndex(PropertyDescriptor property)
		{
			throw new NotImplementedException();
		}

		public Object AddNew()
		{
			return (UnJour)((IBindingList)this).AddNew();
		}

		public void ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool Contains(object value)
		{
			throw new NotImplementedException();
		}

		public void CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

		public int Find(PropertyDescriptor property, object key)
		{
			throw new NotImplementedException();
		}

		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}

		public int IndexOf(object value)
		{
			throw new NotImplementedException();
		}

		public void Insert(int index, object value)
		{
			throw new NotImplementedException();
		}

		public void Remove(object value)
		{
			throw new NotImplementedException();
		}

		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}

		public void RemoveIndex(PropertyDescriptor property)
		{
			throw new NotImplementedException();
		}

		public void RemoveSort()
		{
			throw new NotImplementedException();
		}
	}

}
