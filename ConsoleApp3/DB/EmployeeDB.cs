using ConsoleApp3.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.DB
{
    public class EmployeeDB:DbContext
    {

        //intialize table for Database
        public DbSet<EmployeeModel> EmployeeModels { get; set; }    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Testdb20;Trusted_Connection=True;");
        }

    }
}
