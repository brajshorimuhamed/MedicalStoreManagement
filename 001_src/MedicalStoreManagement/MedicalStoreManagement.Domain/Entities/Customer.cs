using MedicalStoreManagement.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            Sales = new HashSet<Sale>();
        }

        public string Recepts { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
