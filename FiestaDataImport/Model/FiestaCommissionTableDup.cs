using System;
using System.Collections.Generic;

namespace FiestaDataImport.Model
{
    public partial class FiestaCommissionTableDup
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string Duple { get; set; }
        public DateTime DateCt { get; set; }
        public string Name { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal? Balance { get; set; }
        public string StoreNo { get; set; }
        public string TypeCt { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Email4 { get; set; }
        public string Email5 { get; set; }
    }
}
