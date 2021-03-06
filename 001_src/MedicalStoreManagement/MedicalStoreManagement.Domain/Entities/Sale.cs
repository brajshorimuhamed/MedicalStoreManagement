using MedicalStoreManagement.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain.Entities
{
    public class Sale : BaseEntity
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int CustomerID { get; set; }

        public Product Product { get; set; }

        public Customer Customer { get; set; }
    }
}
