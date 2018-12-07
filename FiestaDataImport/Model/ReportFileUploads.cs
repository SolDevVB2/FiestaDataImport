using System;
using System.Collections.Generic;

namespace FiestaDataImport.Model
{
    public partial class ReportFileUploads
    {
        public int FileId { get; set; }
        public Guid FileGuid { get; set; }
        public string FileName { get; set; }
        public string ReportName { get; set; }
        public string UploadedBy { get; set; }
        public DateTime UploadDate { get; set; }
        public string Status { get; set; }
    }
}
