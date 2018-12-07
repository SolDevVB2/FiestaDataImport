using System;
using System.Collections.Generic;

namespace FiestaDataImport.Model
{
    public partial class FiestaRptableDup
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string Duple { get; set; }
        public string StoreNo { get; set; }
        public DateTime? DateRp { get; set; }
        public string PolicyNumber { get; set; }
        public string Narrative { get; set; }
        public string Insured { get; set; }
        public decimal? Payments { get; set; }
        public DateTime? CheckIssuedDate { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Email4 { get; set; }
        public string Email5 { get; set; }
        public string Email6 { get; set; }
        public string ReportMonth { get; set; }
        public int? ReportNumber { get; set; }
    }
}
