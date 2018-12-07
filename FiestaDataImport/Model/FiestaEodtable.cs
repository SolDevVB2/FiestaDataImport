using System;
using System.Collections.Generic;

namespace FiestaDataImport.Model
{
    public partial class FiestaEodtable
    {
        public string StoreNo { get; set; }
        public DateTime ReportDate { get; set; }
        public decimal? EndOfTheDayDeposit { get; set; }
        public string Duple { get; set; }
    }
}
