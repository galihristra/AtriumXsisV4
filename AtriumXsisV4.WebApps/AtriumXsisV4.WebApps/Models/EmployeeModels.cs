using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtriumXsisV4.WebApps.Models
{
    public class EmployeeModels
    {
        public EmployeeModels()
        {

        }

        public string EMPLOYEEID { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public string EMAIL { get; set; }
        public string PHONENUMBER { get; set; }
        public int SALARY { get; set; }
        public string POSITIONID { get; set; }
        public string BOOTCAMP { get; set; }
        public string PROJECTID { get; set; }
        public DateTime? DCREA { get; set; }
        public string VCREA { get; set; }
        public DateTime? DMODI { get; set; }
        public string VMODI { get; set; }
    }
}