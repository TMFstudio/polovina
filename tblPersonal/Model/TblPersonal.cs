using System;
using System.Collections.Generic;

#nullable disable

namespace tblPersonal.Model
{
    public partial class TblPersonal
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }
        public string IdNumber { get; set; }
        public bool Sex { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public byte PersonType { get; set; }
        public byte[] PersonPhoto { get; set; }
        public string SecretCode { get; set; }
    }
}
