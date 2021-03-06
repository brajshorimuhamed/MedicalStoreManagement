using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Products
{
    public interface IProductService
    {
        Task AddProduct(ProductSubmissionModel model);
        Task<IList<Product>> GetProducts();
        Task<IList<Product>> GetProductsCategory();
        Task<IList<Product>> GetProductsById(int productId);
        Task<bool> DeleteProduct(int productId);
        Task<bool> UpdateProduct(ProductUpdateSubmissionModel model);
    }
}
