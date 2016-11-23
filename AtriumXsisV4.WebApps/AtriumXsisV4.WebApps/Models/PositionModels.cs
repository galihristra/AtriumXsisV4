using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtriumXsisV4.WebApps.Models
{
    public class PositionModels
    {
        public PositionModels()
        {

        }

        public string POSITIONID { get; set; }
        public string VPOSNAME { get; set; }
        public DateTime? DCREA { get; set; }
        public string VCREA { get; set; }
        public DateTime? DMODI { get; set; }
        public string VMODI { get; set; }
    }
}