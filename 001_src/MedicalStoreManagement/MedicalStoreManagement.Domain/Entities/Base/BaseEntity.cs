﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain.Entities.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
