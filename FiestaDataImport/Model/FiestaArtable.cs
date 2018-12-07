using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiestaDataImport.Model
{
    public partial class FiestaArtable
    {
        public string StoreNo { get; set; }
        public string ReconType { get; set; }
        public DateTime TransactionDate { get; set; }
        public string InternalReference { get; set; }
        public string Narrative { get; set; }
        public string ExternalReference { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public string ReportMonth { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Email4 { get; set; }
        public string Email5 { get; set; }
        public string Email6 { get; set; }
        public string Duple { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
    }
}
