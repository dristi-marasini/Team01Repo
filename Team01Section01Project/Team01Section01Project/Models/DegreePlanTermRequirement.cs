using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team01Section01Project.Models
{
    public class DegreePlanTermRequirement
    {

        public int DegreePlanTermRequirementID { get; set; }
        public int DegreePlanID { get; set; }
        public int TermID { get; set; }
        public int RequirementID { get; set; }

        [ForeignKey("DegreePlanID")]
   
        public DegreePlan DegreePlan { get; set; }

    }
}
