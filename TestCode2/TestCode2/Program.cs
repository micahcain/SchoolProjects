using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Text.RegularExpressions;

namespace TestCode2
{
	class Program
	{
		public delegate bool NumberPredicate(int number);

		static void Main(string[] args)
		{
            TestLinq();
            TestLinq2();
            TestLinq3();
		}

		private static void TestLinq3()
		{
			List<string> items = new List<string>();
			items.Add("aQua");
			items.Add("RusT");
			items.Add("yElLow");
			items.Add("rEd");

			var startWithR =
				from item in items
				let uppercaseString = item.ToUpper()
				where uppercaseString.StartsWith("R")
				orderby uppercaseString
				select uppercaseString;

			foreach (var item in startWithR)
				Console.Write("{0} ", item);

			Console.WriteLine();

			items.Add("rUbY");
			items.Add("SaFfRon");

			foreach (var item in startWithR)
				Console.Write("{0} ", item);

			Console.WriteLine();
		}

		private static void TestLinq2()
		{
			Employee[] employees = {
									   new Employee("Jason", "Red", 5000M),
									   new Employee("Ashley", "Green", 7600M),
									   new Employee("Matthew", "Indigo", 3587.5M),
									   new Employee("James", "Indigo", 4700.77M),
									   new Employee("Luke", "Indigo", 6200M),
									   new Employee("Jason", "Blue", 3200M),
									   new Employee("Wendy", "Brown", 4236.4M)};

			Console.WriteLine("Original array:");
			foreach (var element in employees)
				Console.WriteLine(element);

			var between4K6K =
				from e in employees
				where e.MonthylSalary >= 4000M && e.MonthylSalary <= 6000M
				select e;

			Console.WriteLine(string.Format(
				"\nEmployees earning in the range {0:C}-{1:C} per month:",
				4000, 6000));
			foreach (var element in between4K6K)
				Console.WriteLine(element);

			var nameSorted =
				from e in employees
				orderby e.LastName, e.FirstName
				select e;

			Console.WriteLine("\nFirst employee when sorted by name:");

			if (nameSorted.Any())
				Console.WriteLine(nameSorted.First());
			else
				Console.WriteLine("not found");

			var lastNames =
				from e in employees
				select e.LastName;

			Console.WriteLine("\nUnique employee last names:");
			foreach (var element in lastNames.Distinct())
				Console.WriteLine(element);

			var names =
				from e in employees
				select new { e.FirstName, Last = e.LastName };

			Console.WriteLine("\nNames only:");
			foreach (var element in names)
				Console.WriteLine(element);

			Console.WriteLine();
		}

		private static void TestLinq()
		{
			int[] values = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

			Console.Write("Original array:");
			foreach (var element in values)
				Console.Write(" {0}", element);

			var filtered =
				from value in values
				where value > 4
				select value;

			Console.Write("\nArray values greater than 4:");
			foreach (var element in filtered)
				Console.Write(" {0}", element);

			var sorted =
				from value in values
				orderby value
				select value;

			Console.Write("\nOriginal array, sorted:");
			foreach (var element in sorted)
				Console.Write(" {0}", element);

			var sortFilteredResults =
				from value in filtered
				orderby value descending
				select value;

			Console.Write("\nValues greater than 4, descending order (separately):");
			foreach (var element in sortFilteredResults)
				Console.Write(" {0}", element);

			var sortAndFilter =
				from value in values
				where value > 4
				orderby value descending
				select value;

			Console.Write("\nValues greater than 4, descending order (one query):");
			foreach (var element in sortAndFilter)
				Console.Write(" {0}", element);

			Console.WriteLine();
		}

		private static void TestAnonymouseTypes()
		{
			var bob = new { Name = "Bob Smith", Age = 37 };

			Console.WriteLine("Bob: " + bob.ToString());

			var steve = new { Name = "Steve Jones", Age = 26 };

			Console.WriteLine("Steve: " + steve.ToString());

			Console.WriteLine("\nBob and Steve are {0}",
				(bob.Equals(steve) ? "equal" : "not equal"));

			var bob2 = new { Name = "Bob Smith", Age = 37 };

			Console.WriteLine("\nBob2: " + bob2.ToString());

			Console.WriteLine("\nBob and Bob2 are {0}\n",
				(bob.Equals(bob2) ? "equal" : "not equals"));
		}

		private static void TestLambdas()
		{
			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			NumberPredicate evenPredicate = number => (number % 2 == 0);

			Console.WriteLine("Use lambda-expression variable: {0}", evenPredicate(4));

			List<int> evenNumbers = FilterArray(numbers, evenPredicate);

			DisplayList("Use a lambda expression to filter even numbers: ", evenNumbers);

			List<int> oddNumbers = FilterArray(numbers, (int number) => (number % 2 == 1));

			DisplayList("Use a lambda expression to filter odd numbers: ", oddNumbers);

			List<int> numbersOver5 = FilterArray(numbers, number => { return number > 5; });

			DisplayList("Use a lambda expression to filter numbers over 5: ", numbersOver5);
		}

		private static void TestDelegates()
		{
			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			NumberPredicate evenPredicate = IsEven;

			Console.WriteLine("Call IsEven using a delegate variable: {0}", evenPredicate(4));

			List<int> evenNumbers = FilterArray(numbers, evenPredicate);

			DisplayList("Use IsEven to filter even numbers: ", evenNumbers);

			List<int> oddNumbers = FilterArray(numbers, IsOdd);

			DisplayList("Use IsOdd to filter odd numbers: ", oddNumbers);

			List<int> numbersOver5 = FilterArray(numbers, IsOver5);

			DisplayList("Use IsOver5 to filter numbers over 5: ", numbersOver5);
		}

		private static bool IsEven(int number)
		{
			return (number % 2 == 0);
		}

		private static bool IsOdd(int number)
		{
			return (number % 2 == 1);
		}

		private static bool IsOver5(int number)
		{
			return (number > 5);
		}

		private static void DisplayList(string description, List<int> list)
		{
			Console.WriteLine(description);

			foreach (int item in list)
				Console.Write("{0} ", item);

			Console.WriteLine();
		}

		private static List<int> FilterArray(int[] intArray, NumberPredicate predicate)
		{
			List<int> result = new List<int>();

			foreach (int item in intArray)
			{
				if (predicate(item))
					result.Add(item);
			}

			return result;
		}

		private static void TestCompare()
		{
			
			List<Employee> employees = new List<Employee>();
			employees.Add(new Employee("Jason", "Nichols", 1M));
			employees.Add(new Employee("Jim", "Rustman", 2M));
			employees.Add(new Employee("Micah", "Cain", 3M));

			Console.WriteLine("List - Unsorted\n");

			foreach (Employee item in employees)
				Console.WriteLine(item);

			employees.Sort();
			Console.WriteLine("List - Sorted by LastName (Ascending - IComparable)\n");

			foreach (Employee item in employees)
				Console.WriteLine(item);

			employees.Sort(Employee.sortFirstNameAscending());
			Console.WriteLine("List - Sorted by FirstName (Ascending - IComparer)\n");

			foreach (Employee item in employees)
				Console.WriteLine(item);

			employees.Sort(Employee.sortFirstNameDescending());
			Console.WriteLine("List - Sorted by FirstName (Descending - IComparer)\n");

			foreach (Employee item in employees)
				Console.WriteLine(item);

			employees.Sort(Employee.sortLastNameDescending());
			Console.WriteLine("List - Sorted by LastName (Descending - IComparer)\n");

			foreach (Employee item in employees)
				Console.WriteLine(item);

			employees.Sort(Employee.sortMonthlySalaryAscending());
			Console.WriteLine("List - Sorted by MonthlySalary (Ascending - IComparer)\n");

			foreach (Employee item in employees)
				Console.WriteLine(item);

			employees.Sort(Employee.sortMonthlySalaryDescending());
			Console.WriteLine("List - Sorted by MonthlySalary (Descending - IComparer)\n");

			foreach (Employee item in employees)
				Console.WriteLine(item);
		}

		private static void TestCompare2()
		{
			List<Employee> employees = new List<Employee>();
			employees.Add(new Employee("Jason", "Nichols", 1M));
			employees.Add(new Employee("Jim", "Rustman", 2M));
			employees.Add(new Employee("Micah", "Cain", 3M));

			//employees.Sort(new EmployeeComparer("FirstName"));
			//foreach (Employee item in employees)
			//    Console.WriteLine(item);

			var sortedMoneyEmployees =
				from e in employees
				where e.FirstName == "Jason"
				select new { e.LastName, e.MonthylSalary };

			if (sortedMoneyEmployees.Any())
				Console.WriteLine(sortedMoneyEmployees.First());
		}

		private static void LinearSearchTest()
		{
			// o(n)

			int searchInt;
			int position;

			LinearArray searchArray = new LinearArray(10);
			Console.WriteLine(searchArray);

			Console.Write("Please enter an integer value (-1 to quit): ");
			searchInt = Convert.ToInt32(Console.ReadLine());

			while (searchInt != -1)
			{
				position = searchArray.LinearSearch(searchInt);

				if (position != -1)
					Console.WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);
				else
					Console.WriteLine("The integer {0} was not found.\n", searchInt);

				Console.Write("Please enter an integer value (-1 to quit): ");
				searchInt = Convert.ToInt32(Console.ReadLine());
			}
		}

		private static void BinarySearchTest()
		{
			// o(log n)

			int searchInt;
			int position;

			BinaryArray searchArray = new BinaryArray(15);
			Console.WriteLine(searchArray);

			Console.Write("Please enter an integer value (-1 to quit): ");
			searchInt = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			while (searchInt != -1)
			{
				position = searchArray.BinarySearch(searchInt);

				if (position == -1)
					Console.WriteLine("The integer {0} was not found.\n", searchInt);
				else
					Console.WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);

				Console.Write("Please enter an integer value (-1 to quit): ");
				searchInt = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();
			}
		}

		private static void SelectionSortTest()
		{
			// o(n^2)

			SelectionSort sortArray = new SelectionSort(10);

			Console.WriteLine("Unsorted array:");
			Console.WriteLine(sortArray);

			sortArray.Sort();

			Console.WriteLine("Sorted array:");
			Console.WriteLine(sortArray);
		}

		private static void InsertionSortTest()
		{
			// o(n^2)

			InsertionSort sortArray = new InsertionSort(10);

			Console.WriteLine("Unsorted array:");
			Console.WriteLine(sortArray);

			sortArray.Sort();

			Console.WriteLine("Sorted array:");
			Console.WriteLine(sortArray);
		}

		private static void BubbleSortTest()
		{
			// o(n^2)

			BubbleSort sortArray = new BubbleSort(10);

			Console.WriteLine("Unsorted array:");
			Console.WriteLine(sortArray);

			sortArray.Sort();

			Console.WriteLine("Sorted array:");
			Console.WriteLine(sortArray);
		}

		private static void BiDirectionalBubbleSortTest()
		{
			// o(n^2)

			BiDirectionalBubbleSort sortArray= new BiDirectionalBubbleSort(10);

			Console.WriteLine("Unsorted array:");
			Console.WriteLine(sortArray);

			sortArray.Sort();

			Console.WriteLine("sorted array:");
			Console.WriteLine(sortArray);
		}

		private static void BucketSortTest()
		{
			// o(n^2.k)

			BucketSort sortArray = new BucketSort(10);

			Console.WriteLine("Unsorted array:");
			Console.WriteLine(sortArray);

			sortArray.Sort();

			Console.WriteLine("sorted array:");
			Console.WriteLine(sortArray);
		}

		private static void MergeSortTest()
		{
			// o(n log n)

			MergeSort sortArray = new MergeSort(10);

			Console.WriteLine("Unsorted: {0}\n", sortArray);

			sortArray.Sort();

			Console.WriteLine("Sorted: {0}", sortArray);
		}

		private static void SinglyLinkedListTest()
		{
			SinglyLinkedList list = new SinglyLinkedList();

			bool aBoolean = true;
			char aCharacter = '$';
			int anInteger = 34567;
			string aString = "hello";

			list.InsertAtFront(aBoolean);
			list.Display();
			list.InsertAtFront(aCharacter);
			list.Display();
			list.InsertAtBack(anInteger);
			list.Display();
			list.InsertAtBack(aString);
			list.Display();

			object removedObject;

			try
			{
				removedObject = list.RemoveFromFront();
				Console.WriteLine(removedObject + " removed");
				list.Display();

				removedObject = list.RemoveFromFront();
				Console.WriteLine(removedObject + " removed");
				list.Display();

				removedObject = list.RemoveFromBack();
				Console.WriteLine(removedObject + " removed");
				list.Display();

				removedObject = list.RemoveFromBack();
				Console.WriteLine(removedObject + " removed");
				list.Display();
			}
			catch (EmptyListException emptyListException)
			{
				Console.Error.WriteLine("\n" + emptyListException);
			}
		}

		private static void DoublyLinkedListTest()
		{
			DoublyLinkedList list = new DoublyLinkedList();

			bool aBoolean = true;
			char aCharacter = '$';
			int anInteger = 34567;
			string aString = "hello";

			list.InsertAtFront(aBoolean);
			list.Display();
			list.InsertAtFront(aCharacter);
			list.Display();
			list.InsertAtBack(anInteger);
			list.Display();
			list.InsertAtBack(aString);
			list.Display();
			list.DisplayBackwards();

			object removedObject;

			try
			{
				removedObject = list.RemoveFromFront();
				Console.WriteLine(removedObject + " removed");
				list.Display();

				removedObject = list.RemoveFromFront();
				Console.WriteLine(removedObject + " removed");
				list.Display();

				removedObject = list.RemoveFromBack();
				Console.WriteLine(removedObject + " removed");
				list.Display();

				removedObject = list.RemoveFromBack();
				Console.WriteLine(removedObject + " removed");
				list.Display();
			}
			catch (EmptyListException emptyListException)
			{
				Console.Error.WriteLine("\n" + emptyListException);
			}
		}

		private static void StackInheritanceTest()
		{
			StackInheritance stack = new StackInheritance();

			bool aBoolean = true;
			char aCharacter = '$';
			int anInteger = 34567;
			string aString = "hello";

			stack.Push(aBoolean);
			stack.Display();
			stack.Push(aCharacter);
			stack.Display();
			stack.Push(anInteger);
			stack.Display();
			stack.Push(aString);
			stack.Display();

			try
			{
				while (true)
				{
					object removedObject = stack.Pop();
					Console.WriteLine(removedObject + " popped");
					stack.Display();
				}
			}
			catch (EmptyListException emptyListException)
			{
				Console.Error.WriteLine(emptyListException.StackTrace);
			}
		}

		private static void QueueInheritanceTest()
		{
			QueueInheritance queue = new QueueInheritance();

			bool aBoolean = true;
			char aCharacter = '$';
			int anInteger = 34567;
			string aString = "hello";

			queue.Enqueue(aBoolean);
			queue.Display();
			queue.Enqueue(aCharacter);
			queue.Display();
			queue.Enqueue(anInteger);
			queue.Display();
			queue.Enqueue(aString);
			queue.Display();

			try
			{
				while (true)
				{
					object removedObject = queue.Dequeue();
					Console.WriteLine(removedObject + " dequeued");
					queue.Display();
				}
			}
			catch (EmptyListException emptyListException)
			{
				Console.Error.WriteLine(emptyListException.StackTrace);
			}
		}

		private static void BinaryTreeTest()
		{
			BinaryTree tree = new BinaryTree();
			int insertValue;

			Console.WriteLine("Inserting values: ");
			Random random = new Random();

			for (int i = 1; i <= 10; i++)
			{
				insertValue = random.Next(100);
				Console.Write(insertValue + " ");

				tree.InsertNode(insertValue);
			}

			Console.WriteLine("\n\nPreorder traversal");
			tree.PreorderTraversal();

			Console.WriteLine("\n\nInorder traversal");
			tree.InorderTraversal();

			Console.WriteLine("\n\nPostorder traversal");
			tree.PostorderTraversal();
			Console.WriteLine();
		}

		private static void BinaryTree2Test()
		{
			int[] intArray = { 8, 2, 4, 3, 1, 7, 5, 6 };
			double[] doubleArray = { 8.8, 2.2, 4.4, 3.3, 1.1, 7.7, 5.5, 6.6 };
			string[] stringArray = { "eight", "two", "three", "one", "seven", "five", "six" };

			BinaryTree2 intTree = new BinaryTree2();
			PopulateTree(intArray, intTree, "intTree");
			TraverseTree(intTree, "intTree");

			BinaryTree2 doubleTree = new BinaryTree2();
			PopulateTree(doubleArray, doubleTree, "doubleTree");
			TraverseTree(doubleTree, "doubleTree");

			BinaryTree2 stringTree = new BinaryTree2();
			PopulateTree(stringArray, stringTree, "stringTree");
			TraverseTree(stringTree, "stringTree");
		}

		private static void PopulateTree(Array array, BinaryTree2 tree, string name)
		{
			Console.WriteLine("\n\n\nInserting into " + name + ":");

			foreach (IComparable data in array)
			{
				Console.Write(data + " ");
				tree.InsertNode(data);
			}
		}

		private static void TraverseTree(BinaryTree2 tree, string treeType)
		{
			Console.WriteLine("\n\nPreorder traversal of " + treeType);
			tree.PreorderTraversal();

			Console.WriteLine("\n\nInorder traversal of " + treeType);
			tree.InorderTraversal();

			Console.WriteLine("\n\nPostorder traversal of " + treeType);
			tree.PostorderTraversal();
		}

		private static void DisplayArray<T>(T[] inputArray)
		{
			foreach (T element in inputArray)
				Console.Write(element + " ");

			Console.WriteLine("\n\n");
		}

		private static void ArrayAlgorithms()
		{
			int[] intValues = { 1, 2, 3, 4, 5, 6 };
			double[] doubleValues = { 8.4, 9.3, 0.2, 7.9, 3.4 };
			int[] intValuesCopy;

			intValuesCopy = new int[intValues.Length];

			PrintArray(intValues, "intValues");
			PrintArray(doubleValues, "doubleValues");
			PrintArray(intValuesCopy, "intValuesCopy");

			Array.Sort(doubleValues);

			Array.Copy(intValues, intValuesCopy, intValues.Length);

			Console.WriteLine("\nArray values after Sort and Copy:\n");
			PrintArray(intValues, "intValues");
			PrintArray(doubleValues, "doubleValues");
			PrintArray(intValuesCopy, "intValuesCopy");
			Console.WriteLine();

			int result = Array.BinarySearch(intValues, 5);
			if (result >= 0)
				Console.WriteLine("5 found at element {0} in intValues", result);
			else
				Console.WriteLine("5 not found in intValues");

			result = Array.BinarySearch(intValues, 8763);
			if (result >= 0)
				Console.WriteLine("8763 found at element {0} in intValues", result);
			else
				Console.WriteLine("8763 not found in intValues");
		}

		private static void PrintArray(Array array, string name)
		{
			Console.Write(name);

			IEnumerator enumerator = array.GetEnumerator();

			while (enumerator.MoveNext())
				Console.Write(enumerator.Current + " ");

			Console.WriteLine();
		}

		private static Hashtable CollectWords()
		{
			Hashtable table = new Hashtable();

			Console.WriteLine("Enter a string: ");
			string input = Console.ReadLine();

			string[] words = Regex.Split(input, @"\s+");

			foreach (var word in words)
			{
				string wordKey = word.ToLower();

				if (table.Contains(wordKey))
					table[wordKey] = ((int)table[wordKey]) + 1;
				else
					table.Add(wordKey, 1);
			}

			return table;
		}

		private static void DisplayHashtable(Hashtable table)
		{
			Console.WriteLine("\nHashtable contains:\n{0, -12}{1, -12}", "Key:", "Value:");

			foreach (var key in table.Keys)
				Console.WriteLine("{0, -12}{1, -12}", key, table[key]);

			Console.WriteLine("\nsize: {0}", table.Count);
		}

		public static void HashTableTest()
		{
			//new application should use Dictionary<K, V> instead of Hashtable

			Hashtable table = CollectWords();

			DisplayHashtable(table);
		}
	}
}