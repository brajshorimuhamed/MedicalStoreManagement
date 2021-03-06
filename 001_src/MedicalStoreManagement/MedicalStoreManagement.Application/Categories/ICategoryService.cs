using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Categories
{
    public interface ICategoryService
    {
        Task AddCategory(CategorySubmissionModel model);
        Task<IList<Category>> GetCategories();
        Task<IList<Category>> GetCategoriesById(int categoryId);
        Task<bool> DeleteCategory(int categoryId);
    }
}
