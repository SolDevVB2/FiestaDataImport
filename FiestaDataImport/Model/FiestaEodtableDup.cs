using System;
using System.Collections.Generic;

namespace FiestaDataImport.Model
{
    public partial class FiestaEodtableDup
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string Duple { get; set; }
        public string StoreNo { get; set; }
        public DateTime ReportDate { get; set; }
        public decimal? EndOfTheDayDeposit { get; set; }
    }
}
