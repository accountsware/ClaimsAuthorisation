﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ClaimsAuth.Infrastructure.Identity
{
    [Table("AspNetRoleClaims")]
    public class RoleClaim
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public String RoleId { get; set; }

        [ForeignKey("RoleId")]
        public ApplicationRole Role { get; set; }

        public String ClaimType { get; set; }
        public String ClaimValue { get; set; }
    }
}