using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PurpleBrick.Section1Linq.Company;

namespace PurpleBrick.Section1Linq
{
    [TestClass]
    public class Company
    {

        [TestMethod]
        public void ExcecuteScript()
        {
            TotalThreeSalaryPaidByCompany();
            MaximumPaid();
            IncreasmentEveryMonthAndFebPaid(2000);
        }


        public static List<PayRoll> EmployeeDetails()
        {
            var EmployeeInfo = new List<PayRoll>();
            EmployeeInfo.Add(new PayRoll
            {
                EmployeeId = 1,
                Name = "Roland David",
                JanSalary = 1080,
                FebSalary = 2200,
                MarchSalary = 3800
            });
            EmployeeInfo.Add(new PayRoll
            {
                EmployeeId = 2,
                Name = "Peter Land",
                JanSalary = 1700,
                FebSalary = 2300,
                MarchSalary = 3000
            });
            EmployeeInfo.Add(new PayRoll
            {
                EmployeeId = 3,
                Name = "Tom Rod",
                JanSalary = 1200,
                FebSalary = 2400,
                MarchSalary = 3200
            });

            return EmployeeInfo;
        }

        /*1. Display/Print Total salary paid by company to all three employees for all three months.*/
        public static void TotalThreeSalaryPaidByCompany()
        {
            int amount = 0;
            var TotalPaidBycompany = 0;

            var extractQuery = EmployeeDetails().GroupBy(x => new
            {
                x.Name
            }).Select(group => new

            {
                Name = group.Key.Name,
                TotalAmount = ((group.Sum(a => a.JanSalary)) + (group.Sum(a => a.FebSalary)) + (group.Sum(a => a.MarchSalary)))
            });

            foreach (var item in extractQuery)
            {
                Console.WriteLine("Employee: {0} three months salary is [{1}] ", item.Name, item.TotalAmount);
                TotalPaidBycompany = (amount += item.TotalAmount);
            }
            Console.WriteLine("The total paid by the company is [{0}] ", TotalPaidBycompany);
        }


        /*2. Display/Print employee details with highest total salary for all three months.*/

        public static void MaximumPaid()
        {

            var Employeelist = from user in EmployeeDetails().ToList()
                               select user;

            var EmployeeMaximumPaidSalary = ((from employee in EmployeeDetails().ToList()
                                              select employee.JanSalary).Union(from employee in EmployeeDetails().ToList()
                                                                               select employee.MarchSalary).Union(from employee in EmployeeDetails().ToList()
                                                                                                                  select employee.JanSalary)).Max();
            foreach (var staffDetails in Employeelist)
            {
                if (staffDetails.JanSalary == EmployeeMaximumPaidSalary)
                {
                    Console.WriteLine("Employee: [{0}] is the highest month paid salary with the value of [{1}]", EmployeeMaximumPaidSalary, staffDetails.Name);
                }
                else if (staffDetails.FebSalary == EmployeeMaximumPaidSalary)
                {
                    Console.WriteLine("Employee: [{0}] is the highest month paid salary with the value of [{1}]", EmployeeMaximumPaidSalary, staffDetails.Name);
                }

                else if (staffDetails.MarchSalary == EmployeeMaximumPaidSalary)
                {
                    Console.WriteLine("Employee: [{0}] is the highest month paid salary with the value of [{1}]", staffDetails.Name, EmployeeMaximumPaidSalary);
                }
            }

        }
        /*3. Display/Print Salary earned by each employee for month of Feb.*/
        /*4. Increase salary of each employee by £2000 for every month and display/print Old and New salary for all three months.*/

        public static void IncreasmentEveryMonthAndFebPaid(int x)
        {
            var Employeelist = from hr in EmployeeDetails().ToList()
                               select hr;

            foreach (var employeeDetails in Employeelist)
            {
                Console.WriteLine("Salary earned by employee: [{0}] in month of Feb is [{1}] : ",
                    employeeDetails.Name, employeeDetails.FebSalary);


                employeeDetails.FebSalary = employeeDetails.FebSalary + (x);
                employeeDetails.JanSalary = employeeDetails.JanSalary + (x);
                employeeDetails.MarchSalary = employeeDetails.MarchSalary + (x);

                Console.WriteLine(" 2000 monthly increasement for [{0}],in the following month : Jan is [{1}], Feb [{2}],March [{3}] ",
                    employeeDetails.Name, employeeDetails.JanSalary, employeeDetails.FebSalary, employeeDetails.MarchSalary);


                int TotalThreeMonthsAfterIncreasement = (employeeDetails.FebSalary + employeeDetails.JanSalary + employeeDetails.MarchSalary);

                Console.WriteLine("The 3 months total salary with 2000 increasement is [{0}] for [{1}]",
                    TotalThreeMonthsAfterIncreasement, employeeDetails.Name);
            }
        }




        public class PayRoll
        {

            public int EmployeeId { get; set; }
            public string Name { get; set; }
            public int JanSalary { get; set; }
            public int FebSalary { get; set; }
            public int MarchSalary { get; set; }


        }
    }

}

