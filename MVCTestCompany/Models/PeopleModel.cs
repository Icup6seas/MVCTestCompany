using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTestCompany
{
    public class PeopleModel
    {
        public int FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int DeptNumber { get; set; }
        public char Type { get; set; }
        public bool IsActive { get; set; } = true;
    }
}