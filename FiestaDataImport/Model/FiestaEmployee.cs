using System;
using System.Collections.Generic;

namespace FiestaDataImport.Model
{
    public partial class FiestaEmployee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Reset { get; set; }
        public bool? IsActive { get; set; }
    }
}
