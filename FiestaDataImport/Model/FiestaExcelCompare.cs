using System;
using System.Collections.Generic;

namespace FiestaDataImport.Model
{
    public partial class FiestaExcelCompare
    {
        public int? Id { get; set; }
        public string DbColName { get; set; }
        public string ExcelColName { get; set; }
        public int ReportId { get; set; }
        public string Datatype { get; set; }
        public bool IsActive { get; set; }
    }
}
