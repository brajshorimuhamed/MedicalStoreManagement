using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain._DTO
{
    public class CategorySubmissionModel
    {
        public string Category_Name { get; set; }
        public int Category_Quantity { get; set; }

        public Category ToEntity()
        {
            return new Category
            {
                Category_Name = Category_Name,
                Category_Quantity = Category_Quantity
            };
        }
    }
}
