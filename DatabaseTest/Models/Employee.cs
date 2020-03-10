using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DatabaseTest.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int ManagerID { get; set; }

        public int BranchID { get; set; }

        public string Role { get; set; }

        public DateTime StartDate { get; set; }

    }
}