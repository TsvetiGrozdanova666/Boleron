using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boleron.DBmodels
{
    public class User: IdentityUser
    {
        public int EGN { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public float Salary { get; set; }

        public List<CarPolicy> CarPolicies { get; set; }

        public List<ExtremePolicy> ExtremePolicies { get; set; }

    }
}
