using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TestCode2
{
	public class EntityPropertyComparer : IComparer
	{
		private string _propertyName;

		public EntityPropertyComparer(string propertyName)
		{
			this._propertyName = propertyName;
		}

		public int Compare(object x, object y)
		{
			object a = x.GetType().GetProperty(this._propertyName).GetValue(x, null);
			object b = y.GetType().GetProperty(this._propertyName).GetValue(y, null);

			if (a != null && b == null)
				return 1;

			if (a == null && b != null)
				return -1;

			if (a == null && b == null)
				return 0;

			return ((IComparable)a).CompareTo(b);
		}
	}
}