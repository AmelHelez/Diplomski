﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Salon
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }
        public int EmployeeNumber { get; set; }

        public byte[] Image { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public List<User>? Users { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }


    }
}
