﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Slot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1, 999)]
        public int SlotId { get; set; }

        [ForeignKey("DegreePlanId")]
        [Range(1, 99999)]
        public int DegreePlanId { get; set; }

        [ForeignKey("StudentTermId")]
        [Range(1, 999)]
        public int StudentTermId { get; set; }

        [Range(1, 999)]
        public int CreditId { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        public StudentTerm StudentTerm { get; set; }
        public Credit Credit { get; set; }
        public DegreePlan DegreePlan { get; set; }
    }
}