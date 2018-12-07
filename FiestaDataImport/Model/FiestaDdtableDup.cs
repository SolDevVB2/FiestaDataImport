using System;
using System.Collections.Generic;

namespace FiestaDataImport.Model
{
    public partial class FiestaDdtableDup
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string Duple { get; set; }
        public string StoreNo { get; set; }
        public DateTime? ReportDate { get; set; }
        public decimal? Eoddeposit { get; set; }
        public decimal? ActualDeposit { get; set; }
        public string DepositOver { get; set; }
        public DateTime? DepositDate { get; set; }
        public decimal? EodcreditCards { get; set; }
        public decimal? ActualCreditCards { get; set; }
        public string OverCreditCards { get; set; }
        public decimal? VoidCredits { get; set; }
        public string PayoutTo { get; set; }
        public decimal? PayoutCheck { get; set; }
        public decimal? ScanningViolationFees { get; set; }
        public decimal? DepositViolationFees { get; set; }
        public decimal? ArviolationFees { get; set; }
        public decimal? ViolationFeesTotal { get; set; }
        public string Comments { get; set; }
        public string ReportMonth { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Email4 { get; set; }
        public string Email5 { get; set; }
        public string Email6 { get; set; }
        public string EmailStore { get; set; }
        public int? MonthNumber { get; set; }
    }
}
