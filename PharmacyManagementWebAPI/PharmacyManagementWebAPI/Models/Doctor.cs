﻿using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementWebAPI.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DocName { get; set; }
        public string DocEmail { get; set; }
        public double DocPhnNum { get; set; }
        public string DocPassword { get; set; }
        public string DocAddress { get; set; }
        //public ICollection<Order> Orders { get; set; }
    }
}
