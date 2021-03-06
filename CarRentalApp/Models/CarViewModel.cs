﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Models
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int ManufactureYear { get; set; }
        public string RegistrationNumber { get; set; }
        public OrderViewModel Order { get; set; }
    }
}
