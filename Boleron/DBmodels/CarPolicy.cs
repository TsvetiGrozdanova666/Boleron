using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boleron.DBmodels
{
    public class CarPolicy
    {

        public int CarPolicyID { get; set; }

        public string OwnerID { get; set; }

        public User Owner { get; set; }

        public int MoneyLimitOfInsurance { get; set; }

        public DateTime BegginingOfInsurance { get; set; }

        public int MonthsOfInsurance { get; set; }

        public int CarAge { get; set; }

        public string CarBrand { get; set; }

        public string CarNumber { get; set; }

        public string CarColour { get; set; }

    }
}
