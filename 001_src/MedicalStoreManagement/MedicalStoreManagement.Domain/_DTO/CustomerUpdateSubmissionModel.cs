using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain._DTO
{
    public class CustomerUpdateSubmissionModel
    {
        public int Id { get; set; }
        public string Recepts { get; set; }
        public int ProductID { get; set; }

        public Customer ToEntity()
        {
            return new Customer
            {
                Id = Id,
                Recepts = Recepts,
                ProductId = ProductID
            };
        }
    }
}
