using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
    public class Info
    {
        private string startDate;
        private string endDate;
        private string sign;

        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public string Sign { get => sign; set => sign = value; }
    }
}
