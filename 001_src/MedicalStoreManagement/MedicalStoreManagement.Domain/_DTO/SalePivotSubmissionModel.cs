using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain._DTO
{
    public class SalePivotSubmissionModel
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int CustomerPivotID { get; set; }

        public SalePivot ToEntity()
        {
            return new SalePivot
            {
                ProductID = ProductID,
                Quantity = Quantity,
                Price = Price,
                CustomerPivotId = CustomerPivotID
            };
        }
    }
}
