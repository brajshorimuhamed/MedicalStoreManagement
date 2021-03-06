using MedicalStoreManagement.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain.Entities
{
    public class Inventory : BaseEntity
    {
        public string Inventory_Name { get; set; }
        public string ImageName { get; set; }
    }
}
