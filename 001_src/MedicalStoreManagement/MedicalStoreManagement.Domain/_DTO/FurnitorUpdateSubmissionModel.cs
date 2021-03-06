using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain._DTO
{
    public class FurnitorUpdateSubmissionModel
    {
        public int Id { get; set; }
        public string Furnitor_FirstName { get; set; }
        public string Furnitor_LastName { get; set; }
        public int Furnitor_NrPhone { get; set; }
        public string Furnitor_Email { get; set; }
        public string Furnitor_Address { get; set; }

        public Furnitor ToEntity()
        {
            return new Furnitor
            {
                Id = Id,
                Furnitor_FirstName = Furnitor_FirstName,
                Furnitor_LastName = Furnitor_LastName,
                Furnitor_NrPhone = Furnitor_NrPhone,
                Furnitor_Email = Furnitor_Email,
                Furnitor_Address = Furnitor_Address
            };
        }
    }
}
