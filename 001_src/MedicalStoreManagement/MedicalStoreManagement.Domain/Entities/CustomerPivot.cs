using MedicalStoreManagement.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain.Entities
{
    public class CustomerPivot : BaseEntity
    {
        public CustomerPivot()
        {
            SalePivots = new HashSet<SalePivot>();
        }

        public string Research { get; set; }
        public int ProductId { get; set; }
        public bool ProductStatus { get; set; }

        public Product Product { get; set; }

        public ICollection<SalePivot> SalePivots { get; set; }
    }
}
