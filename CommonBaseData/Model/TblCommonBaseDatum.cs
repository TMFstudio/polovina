using System;
using System.Collections.Generic;

#nullable disable

namespace CommonBaseData.Model
{
    public partial class TblCommonBaseDatum
    {
        public int CommonBaseDataId { get; set; }
        public string BaseCode { get; set; }
        public string BaseValue { get; set; }
        public int? CommonBaseTypeId { get; set; }
    }
}
