using System;
using System.Collections.Generic;

namespace Team01Section01Project.Models
{
    public class DegreePlan
    {
        public int DegreePlanID { get; set; }
        public int Degreeid { get; set; }
        public int studentid { get; set; }
        public String DegreePlanAbrevation { get; set; }
        public String DegreePlanName { get; set; }
    }
}
