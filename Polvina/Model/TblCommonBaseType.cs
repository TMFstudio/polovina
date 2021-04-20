using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CommonBaseType.Model
{
    [Table("tblCommonBaseType")]
    [Index(nameof(BaseTypeCode), Name = "IX_tblCommonBaseType", IsUnique = true)]
    [Index(nameof(BaseTypeTitle), Name = "test", IsUnique = true)]
    public partial class TblCommonBaseType
    {
        [Key]
        public int CommonBaseTypeId { get; set; }
        [Required]
        [StringLength(900)]
        public string BaseTypeTitle { get; set; }
        [StringLength(3)]
        public string BaseTypeCode { get; set; }
    }
}
