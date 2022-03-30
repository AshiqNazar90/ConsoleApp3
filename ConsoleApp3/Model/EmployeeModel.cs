using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Model
{
    public class EmployeeModel
    {
        [Key]

        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
    }
}
