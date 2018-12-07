using System;
using System.Collections.Generic;

namespace FiestaDataImport.Model
{
    public partial class FiestaEmpStoreReport
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string StoreNo { get; set; }
        public int ReportId { get; set; }
        public DateTime? AssignDate { get; set; }
    }
}
