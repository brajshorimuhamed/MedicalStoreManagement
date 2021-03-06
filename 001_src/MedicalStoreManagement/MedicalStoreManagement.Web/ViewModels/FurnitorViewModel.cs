using MedicalStoreManagement.Application.Furnitors;
using MedicalStoreManagement.Application.Helpers;
using MedicalStoreManagement.Domain.Entities;
using MedicalStoreManagement.Web.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Web.ViewModels
{
    public class FurnitorViewModel : BaseViewModel
    {
        #region Properties
        public IList<Furnitor> Furnitors { get; set; }
        #endregion

        #region Input
        public int Id { get; set; }
        public string Furnitor_FirstName { get; set; }
        public string Furnitor_LastName { get; set; }
        public int Furnitor_NrPhone { get; set; }
        public string Furnitor_Email { get; set; }
        public string Furnitor_Address { get; set; }
        #endregion

        #region Init
        public override void Init()
        {
            if (initialized) return;
            Furnitors = HttpContextHelper.Context.RequestServices.GetRequiredService<IFurnitorService>().GetFurnitors().Result;
            base.Init();
        }
        #endregion

        #region Load Data
        public void LoadData(int furnitorId)
        {
            try
            {
                var furnitor = Furnitors.FirstOrDefault(x => x.Id == furnitorId);
                Id = furnitor.Id;
                Furnitor_FirstName = furnitor.Furnitor_FirstName;
                Furnitor_LastName = furnitor.Furnitor_LastName;
                Furnitor_NrPhone = furnitor.Furnitor_NrPhone;
                Furnitor_Email = furnitor.Furnitor_Email;
                Furnitor_Address = furnitor.Furnitor_Address;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
