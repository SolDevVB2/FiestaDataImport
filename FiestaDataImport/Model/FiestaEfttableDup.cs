using System;
using System.Collections.Generic;

namespace FiestaDataImport.Model
{
    public partial class FiestaEfttableDup
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string StoreNo { get; set; }
        public DateTime? DateOfReceipt { get; set; }
        public string NameOfCustomer { get; set; }
        public string PolicyNumber { get; set; }
        public string InsuranceCompany { get; set; }
        public decimal? Premium { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Email4 { get; set; }
        public string Email5 { get; set; }
        public string Email6 { get; set; }
        public string Duple { get; set; }
    }
}
