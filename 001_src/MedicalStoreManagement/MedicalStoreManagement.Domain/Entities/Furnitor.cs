using MedicalStoreManagement.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain.Entities
{
    public class Furnitor : BaseEntity
    {
        public Furnitor()
        {
            Products = new HashSet<Product>();
            Purchases = new HashSet<Purchase>();
        }

        public string Furnitor_FirstName { get; set; }
        public string Furnitor_LastName { get; set; }
        public int Furnitor_NrPhone { get; set; }
        public string Furnitor_Email { get; set; }
        public string Furnitor_Address { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Purchase> Purchases { get; set; }
    }
}
