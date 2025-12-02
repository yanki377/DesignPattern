using System;
using System.Collections.Generic;

namespace DesignPattern.Adapter
{ //converts HR's string employee data
    //  into a List so the BillingSystem can use it.

    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> employees = new();

            // Convert each row of the HR array into an Employee object.
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                employees.Add(new Employee(
                    int.Parse(employeesArray[i, 0]),
                    employeesArray[i, 1],
                    employeesArray[i, 2],
                    decimal.Parse(employeesArray[i, 3])
                ));
            }

            Console.WriteLine("Adapter converted Array to Employee List and sent to Billing System:\n");
            
            // Pass the converted data to the third-party system.
            thirdPartyBillingSystem.ProcessSalary(employees);
        }
    }
}

