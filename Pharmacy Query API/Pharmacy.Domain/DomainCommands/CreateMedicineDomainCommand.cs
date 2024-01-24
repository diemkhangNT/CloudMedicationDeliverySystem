﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.DomainCommands
{
    public class CreateMedicineDomainCommand
    {
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public decimal Price { get; set; }
    }
}
