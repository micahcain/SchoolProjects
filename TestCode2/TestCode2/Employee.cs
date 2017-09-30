using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCode2
{
	public class Employee : IComparable<Employee>
	{
		private decimal monthlySalaryValue;

		public Employee(string first, string last, decimal salary)
		{
			this.FirstName = first;
			this.LastName = last;
			this.MonthylSalary = salary;
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }

		public decimal MonthylSalary
		{
			get
			{
				return monthlySalaryValue;
			}

			set
			{
				if (value >= 0M)
					monthlySalaryValue = value;
			}
		}

		public override string ToString()
		{
			return string.Format("{0,-10} {1,-10} {2,10:C}",
				FirstName, LastName, MonthylSalary);
		}

		public static IComparer<Employee> sortFirstNameAscending()
		{
			return new sortFirstNameAscendingHelper();
		}

		public static IComparer<Employee> sortFirstNameDescending()
		{
			return new sortFirstNameDescendingHelper();
		}

		public static IComparer<Employee> sortLastNameDescending()
		{
			return new sortLastNameDescendingHelper();
		}

		public static IComparer<Employee> sortMonthlySalaryAscending()
		{
			return new sortMonthlySalaryAscendingHelper();
		}

		public static IComparer<Employee> sortMonthlySalaryDescending()
		{
			return new sortMonthlySalaryDescendingHelper();
		}

		private class sortFirstNameAscendingHelper : IComparer<Employee>
		{
			public int Compare(Employee x, Employee y)
			{
				return string.Compare(x.FirstName, y.FirstName);
			}
		}

		private class sortFirstNameDescendingHelper : IComparer<Employee>
		{
			public int Compare(Employee x, Employee y)
			{
				return string.Compare(y.FirstName, x.FirstName);
			}
		}

		private class sortLastNameDescendingHelper : IComparer<Employee>
		{
			public int Compare(Employee x, Employee y)
			{
				return string.Compare(y.LastName, x.LastName);
			}
		}

		private class sortMonthlySalaryAscendingHelper : IComparer<Employee>
		{
			public int Compare(Employee x, Employee y)
			{
				return decimal.Compare(x.MonthylSalary, y.MonthylSalary);
			}
		}

		private class sortMonthlySalaryDescendingHelper : IComparer<Employee>
		{
			public int Compare(Employee x, Employee y)
			{
				return decimal.Compare(y.MonthylSalary, x.MonthylSalary);
			}
		}

		public int CompareTo(Employee other)
		{
			return string.Compare(this.LastName, other.LastName);
		}
	}

	public class EmployeeComparer : IComparer<Employee>
	{
		public EmployeeComparer()
		{
		}

		public EmployeeComparer(string propertyName)
		{
			this.WhichComparison = propertyName;
		}

		public bool Equals(Employee a, Employee b)
		{
			return this.Compare(a, b) == 0;
		}

		public int GetHashCode(Employee entity)
		{
			return entity.GetHashCode();
		}

		public int Compare(Employee a, Employee b)
		{
			EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.WhichComparison);
			return entityPropertyComparer.Compare(a, b);
		}

		public string WhichComparison { get; set; }
	}
}