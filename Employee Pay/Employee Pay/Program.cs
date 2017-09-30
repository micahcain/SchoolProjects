using System;
using System.Collections.ObjectModel;

namespace Employee_Pay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Employee Pay";
            
            var numberOfEmployees = 0;
            var employees = new Collection<Employee>();

            Console.Write("How many employees will you be entering? -->");

            while (int.TryParse(Console.ReadLine(),out numberOfEmployees) == false)
            Console.Write("How many employees will you be entering? -->");

            #region "Add employees to the collection
            for (var i = 0; i < numberOfEmployees; i++)
            {
                var employeeLastName = "";
                var employeeFirstName = "";
                const string totalWeeklySalesString = "-1.0";
                double totalWeeklySales = -1.0;

                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------");

                while (String.IsNullOrEmpty(employeeLastName))
                {
                    Console.Write("Please enter the employee's last name -->");
                    employeeLastName = Console.ReadLine();
                }

                while (String.IsNullOrEmpty(employeeFirstName))
                {
                    Console.Write("Please enter the employee's first name. -->");
                    employeeFirstName = Console.ReadLine();
                }

                while (totalWeeklySales < 0.0)
                {
                    Console.Write("Please enter the total sales for the week. -->");
                    if (double.TryParse(Console.ReadLine(), out totalWeeklySales) == false)
                        totalWeeklySales = -1.0;
                }
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------");

                employees.Add(new Employee(employeeLastName, employeeFirstName, totalWeeklySales));

            }
            #endregion

            #region "Print out all employee's results"
            foreach (Employee currentEmp in employees)
            {
                Console.WriteLine(currentEmp.employeeFinalPay());
            }
            #endregion

        }

    }
}
