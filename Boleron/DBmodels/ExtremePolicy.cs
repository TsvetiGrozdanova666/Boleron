using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boleron.DBmodels
{
    public class ExtremePolicy
    {
        public int ExtremePolicyID { get; set; }

        public string OwnerID { get; set; }

        public User Owner { get; set; }

        public int MoneyLimitOfInsurance { get; set; }

        public DateTime BegginingOfInsurance { get; set; }

        public int MonthsOfInsurance { get; set; }

        public bool PractisesExtremeSport { get; set; }

        public int NumberOfTimesAYearToPractise { get; set; }



    }
}
