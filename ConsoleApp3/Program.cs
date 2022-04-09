using ConsoleApp3.DB;
using ConsoleApp3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeModel value = new EmployeeModel();

            value.EmployeeID = Console.ReadLine();
            value.Name = Console.ReadLine();
            value.Designation = Console.ReadLine();

            EmployeeDB dbContext= new EmployeeDB();
            //Add a row in table
            dbContext.Add(value);
            dbContext.SaveChanges();

            var data = dbContext.EmployeeModels.ToList();

            foreach(var item in data)
            {
                Console.WriteLine(item.EmployeeID);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Designation);
            }

        }
    }
}
