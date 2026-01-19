using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lambda.EmployeeManagement
{
    public class EmployeeMain
    {
        /*
        Given a collection of objects representing employees with properties like Name, Department, and JoiningDate, use a lambda expression to filter employees who joined in the last six months and are from a specific department.
        */
        public static void Execute()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Name = "Alice", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-2) });
            employees.Add(new Employee { Name = "Bob", Department = "HR", JoiningDate = DateTime.Now.AddMonths(-3) });
            employees.Add(new Employee { Name = "Charley", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-1) });
            employees.Add(new Employee { Name = "Dustin", Department = "HR", JoiningDate = DateTime.Now.AddMonths(-4) });

            DateTime sixMonthsAgo = DateTime.Now.AddMonths(-6);
            string targetDept = "IT";

            var filteredEmployees = employees.FindAll(e => e.Department == targetDept && e.JoiningDate >= sixMonthsAgo).ToList();

            Console.WriteLine("Employees who joined in last 6 months and belong to IT department:");
            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine($"Name: {emp.Name}");
                Console.WriteLine($"Department: {emp.Department}");
                Console.WriteLine($"Joining Date: {emp.JoiningDate.ToShortDateString()}");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}