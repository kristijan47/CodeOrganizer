using System;
using System.Collections.Generic;
using System.Text;
using CodeOrginizer.Enum_Roles;


namespace CodeOrginizer.Entities
{
    public class Job
    {
        public string CompanyName { get; set; }
        public Address Address { get; set; }
        public Role Role { get; set; }

    }
}
