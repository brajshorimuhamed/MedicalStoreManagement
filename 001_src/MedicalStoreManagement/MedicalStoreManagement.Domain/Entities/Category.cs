using MedicalStoreManagement.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string Category_Name { get; set; }
        public int Category_Quantity { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
