using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain._DTO
{
    public class PurchaseUpdateSubmissionModel
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int FurnitorID { get; set; }

        public Purchase ToEntity()
        {
            return new Purchase
            {
                Id = Id,
                ProductID = ProductID,
                Quantity = Quantity,
                Price = Price,
                FurnitorID = FurnitorID
            };
        }
    }
}
