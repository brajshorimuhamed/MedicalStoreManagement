using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain._DTO
{
    public class ProductUpdateSubmissionModel
    {
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public string Unit { get; set; }
        public string PricePerUnit { get; set; }
        public int FurnitorID { get; set; }
        public string CompanyName { get; set; }
        public int CategoryID { get; set; }
        public string Product_Description { get; set; }

        public Product ToEntity()
        {
            return new Product
            {
                Id = Id,
                Product_Name = Product_Name,
                Unit = Unit,
                PricePerUnit = PricePerUnit,
                FurnitorID = FurnitorID,
                CompanyName = CompanyName,
                CategoryID = CategoryID,
                Product_Description = Product_Description
            };
        }
    }
}
