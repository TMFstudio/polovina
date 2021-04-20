using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Payment.Model
{
    [Table("tblPayment")]
    public partial class TblPayment
    {
        [Key]
        public int PaymentId { get; set; }
        public int? DonatorId { get; set; }
        public int CashAssistanceDetailId { get; set; }
        [Column(TypeName = "decimal(19, 3)")]
        public decimal PaymentPrice { get; set; }
        [StringLength(10)]
        public string PaymentGatewayId { get; set; }
        [Column(TypeName = "date")]
        public DateTime PaymentDate { get; set; }
        public TimeSpan PaymentTime { get; set; }
        [Required]
        [StringLength(500)]
        public string PaymentStatus { get; set; }
        [StringLength(10)]
        public string SourceAccoutNumber { get; set; }
        [Required]
        [StringLength(10)]
        public string TargetAccountNumber { get; set; }
        public int CharityAccountId { get; set; }
        [Required]
        [StringLength(10)]
        public string FollowCode { get; set; }
        public int? NeedyId { get; set; }
    }
}
