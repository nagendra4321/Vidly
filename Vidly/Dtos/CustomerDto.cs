﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetters { get; set; }

  //      [Minimum18YearsIfAMember]
        public DateTime? Birthdate { get; set; }


        public byte MembershipTypeId { get; set; }
    }
}