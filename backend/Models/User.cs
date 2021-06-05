﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace backend.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public byte[] Password { get; set; }
        public byte[] PasswordKey { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        [MaxLength(12)]
        public string Mobile { get; set; }

        public int RoleId { get; set; }

        [JsonIgnore]
        public virtual Role Role { get; set; }

        public int? SalonId { get; set; }
        public virtual Salon Salon { get; set; }

        public virtual ICollection<Appointment>? Appointments { get; set; }

    }
}
