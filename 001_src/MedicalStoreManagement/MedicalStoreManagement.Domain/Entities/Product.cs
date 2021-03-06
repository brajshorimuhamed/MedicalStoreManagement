using MedicalStoreManagement.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain.Entities
{
    public class Product : BaseEntity
    {
        public Product()
        {
            Sales = new HashSet<Sale>();
            Purchases = new HashSet<Purchase>();
            Customers = new HashSet<Customer>();
            CustomerPivots = new HashSet<CustomerPivot>();
            SalePivots = new HashSet<SalePivot>();
        }

        public string Product_Name { get; set; }
        public string Unit { get; set; }
        public string PricePerUnit { get; set; }
        public int FurnitorID { get; set; }
        public string CompanyName { get; set; }
        public int CategoryID { get; set; }
        public string Product_Description { get; set; }

        public Furnitor Furnitor { get; set; }

        public Category Category { get; set; }

        public ICollection<Sale> Sales { get; set; }

        public ICollection<Purchase> Purchases { get; set; }

        public ICollection<Customer> Customers { get; set; }

        public ICollection<CustomerPivot> CustomerPivots { get; set; }

        public ICollection<SalePivot> SalePivots { get; set; }
    }
}
