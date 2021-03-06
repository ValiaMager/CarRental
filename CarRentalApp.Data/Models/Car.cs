﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalApp.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int ManufactureYear { get; set; }
        public string RegistrationNumber { get; set; }
        public List<Order> Orders { get; set; }
    }
}
