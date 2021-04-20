using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NeedyAccounts.Model
{
    [Table("tblNeedyAccounts")]
    [Index(nameof(NeedyId), nameof(AccountNumber), Name = "IX_tblNeedyid", IsUnique = true)]
    [Index(nameof(ShebaNumber), Name = "IX_tblshebaNumber", IsUnique = true)]
    public partial class TblNeedyAccount
    {
        [Key]
        [Column("tblNeedyAccounts")]
        public int TblNeedyAccounts { get; set; }
        public int BankId { get; set; }
        public int NeedyId { get; set; }
        [Required]
        [StringLength(1000)]
        public string OwnerName { get; set; }
        [StringLength(20)]
        public string CardNumber { get; set; }
        [Required]
        [StringLength(10)]
        public string AccountNumber { get; set; }
        [StringLength(500)]
        public string AccountName { get; set; }
        [Required]
        [StringLength(26)]
        public string ShebaNumber { get; set; }
    }
}
