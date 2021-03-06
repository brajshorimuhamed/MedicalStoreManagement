using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain._DTO
{
    public class SaleSubmissionModel
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int CustomerID { get; set; }

        public Sale ToEntity()
        {
            return new Sale
            {
                ProductID = ProductID,
                Quantity = Quantity,
                Price = Price,
                CustomerID = CustomerID
            };
        }
    }
}
