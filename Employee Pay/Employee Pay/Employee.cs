using System;
using System.Text;

namespace Employee_Pay
{
    class Employee
    {
        public const double COMMISSION = .07;
        public const double FED_TAX = .18;
        public const double RETIREMENT = .1;
        public const double SOC_SEC = .06;

        private String _employeeLastName;
        private String _employeeFirstName;
        private double _salesForWeek;

        private double _grossPay;
        private double _fedTaxDeduction;
        private double _retirementDeduction;
        private double _socSecDeduction;
        private double _netPay;
        
        public String employeeLastName
        {
            get { return _employeeLastName; }
            set { _employeeLastName = value; }
        }

        public String employeeFirstName
        {
            get { return _employeeFirstName; }
            set { _employeeFirstName = value; }

        }

        public double salesForWeek
        {
            get { return _salesForWeek; }
            set { _salesForWeek = value; }
        }

        public double grossPay
        {
            get { return _grossPay; }
            set { _grossPay = value; }
        }

        public double fedTaxDeduction
        {
            get { return _fedTaxDeduction;}
            set { _fedTaxDeduction = value; }
        }

        public double retirementDeduction
        {
            get { return _retirementDeduction;}
            set { _retirementDeduction = value; }
        }

        public double socSecDeduction
        {
            get { return _socSecDeduction; }
            set { _socSecDeduction = value; }
        }

        public double netPay
        {
            get { return _netPay; }
            set { _netPay = value; }
        }

        public Employee()
        {}

        public Employee(String lastName, String firstName, double SalesForWeek)
        {
            employeeLastName = lastName;
            employeeFirstName = firstName;
            salesForWeek = SalesForWeek;
        }

        public String employeeFinalPay()
        {
            var sb = new StringBuilder();
            grossPay = salesForWeek * COMMISSION;
            fedTaxDeduction = grossPay * FED_TAX;
            retirementDeduction = grossPay * RETIREMENT;
            socSecDeduction = grossPay * SOC_SEC;
            netPay = grossPay - fedTaxDeduction - retirementDeduction - socSecDeduction;

            sb.AppendLine().AppendLine("-------------------------------------------------------------------");
            sb.AppendLine("For employee " + employeeLastName + " , " + employeeFirstName);
            sb.AppendLine("For Sales period ending: " + DateTime.Today.Month + "/" + DateTime.Today.Day + "/" +
                      DateTime.Today.Year);
            sb.AppendLine("-------------------------------------------------------------------");
            sb.AppendLine("Gross Earnings: " + String.Format("{0:C}", grossPay));
            sb.AppendLine("Federal Tax Withheld: " + String.Format("{0:C}", fedTaxDeduction));
            sb.AppendLine("Retirement Contribution: " + String.Format("{0:C}", retirementDeduction));
            sb.AppendLine("Social Security Deduction: " + String.Format("{0:C}", socSecDeduction));
            sb.AppendLine("Total Deductions This Period: " +
                          String.Format("{0:C}", (fedTaxDeduction + retirementDeduction + socSecDeduction)));
            sb.AppendLine("Net Pay This Period: " + String.Format("{0:C}", netPay));
            sb.AppendLine("-------------------------------------------------------------------");

            return sb.ToString();
        }
    }
}
