using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team01Section01Project.Models;

namespace Team01Section01Project.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.DegreePlanTermRequirements.Any())
            {
                Console.WriteLine("Degree Plan Term Requirements already exists!");
            }
            else
            {
                var degreePlanTermRequirements = new DegreePlanTermRequirement[]
                {
                    new DegreePlanTermRequirement{ DegreePlanTermRequirementID =1,DegreePlanID=10,TermID=1,RequirementID=460}   
                };
            Console.WriteLine($"Inserted {degreePlanTermRequirements.Length} new degree plan term requirements");
                foreach(DegreePlanTermRequirement d in degreePlanTermRequirements)
                {
                    context.DegreePlanTermRequirements.Add(d);
                }
                context.SaveChanges();
            }
        }
    }
}
