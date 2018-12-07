using System;
using System.Collections.Generic;

namespace FiestaDataImport.Model
{
    public partial class FiestaEmpStates
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int StateId { get; set; }
        public DateTime? AssignDate { get; set; }
    }
}
