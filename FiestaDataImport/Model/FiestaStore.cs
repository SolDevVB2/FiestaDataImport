using System;
using System.Collections.Generic;

namespace FiestaDataImport.Model
{
    public partial class FiestaStore
    {
        public string StoreNo { get; set; }
        public int StateId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
