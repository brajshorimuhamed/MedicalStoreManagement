using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain._DTO
{
    public class InventorySubmissionModel
    {
        public string Inventory_Name { get; set; }
        public string ImageName { get; set; }

        public Inventory ToEntity()
        {
            return new Inventory
            {
                Inventory_Name = Inventory_Name,
                ImageName = ImageName
            };
        }
    }
}
