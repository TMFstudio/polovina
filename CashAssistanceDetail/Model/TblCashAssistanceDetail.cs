using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CashAssistanceDetail.Model
{
    [Table("tblCashAssistanceDetail")]
    [Index(nameof(AssignNeedyPlanId), Name = "IX_AssignceDetailld", IsUnique = true)]
    [Index(nameof(PlanId), Name = "IX_plan", IsUnique = true)]
    public partial class TblCashAssistanceDetail
    {
        [Key]
        public int CashAssistanceDetailId { get; set; }
        public int AssignNeedyPlanId { get; set; }
        public int PlanId { get; set; }
        [Column(TypeName = "decimal(19, 3)")]
        public decimal NeededPrice { get; set; }
        [Column(TypeName = "decimal(19, 3)")]
        public decimal? MinPrice { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
    }
}
