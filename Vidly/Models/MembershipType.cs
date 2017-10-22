﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMOnths { get; set; }
        public byte DiscountRate { get; set; }
        
    }
}