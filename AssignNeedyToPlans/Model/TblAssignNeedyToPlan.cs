using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AssignNeedyToPlans.Model
{
    [Table("tblAssignNeedyToPlans")]
    [Index(nameof(NeedyId), nameof(PlanId), Name = "IX_Needyid", IsUnique = true)]
    public partial class TblAssignNeedyToPlan
    {
        [Key]
        public int AssignNeedyPlanId { get; set; }
        public int NeedyId { get; set; }
        public int PlanId { get; set; }
        [Required]
        [StringLength(10)]
        public string Fdate { get; set; }
        [Required]
        [StringLength(10)]
        public string Tdate { get; set; }
    }
}
