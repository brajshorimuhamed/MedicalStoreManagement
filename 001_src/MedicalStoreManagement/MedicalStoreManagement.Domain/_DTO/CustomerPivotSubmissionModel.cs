using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain._DTO
{
    public class CustomerPivotSubmissionModel
    {
        public string Research { get; set; }
        public int ProductID { get; set; }
        public bool ProductStatus { get; set; }

        public CustomerPivot ToEntity()
        {
            return new CustomerPivot
            {
                Research = Research,
                ProductId = ProductID,
                ProductStatus = ProductStatus
            };
        }
    }
}
