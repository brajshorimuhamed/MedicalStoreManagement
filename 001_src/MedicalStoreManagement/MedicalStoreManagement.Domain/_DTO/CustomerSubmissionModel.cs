using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain._DTO
{
    public class CustomerSubmissionModel
    {
        public string Recepts { get; set; }
        public int ProductID { get; set; }

        public Customer ToEntity()
        {
            return new Customer
            {
                Recepts = Recepts,
                ProductId = ProductID
            };
        }
    }
}
