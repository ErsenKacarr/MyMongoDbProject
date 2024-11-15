using MongoDBProject.Dtos.ProductDtos;
using MongoDBProject.Models;

namespace MongoDBProject.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto ProductDto);
        Task UpdateProductAsync(UpdateProductDto ProductDto);
        Task DeleteProductAsync(string id);
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
        Task<List<ResultProductsWithCategoryDto>> GetProductsWithCategoryAsync();
        Task<List<ProductWithCategoryListExcelViewModel>> GetProductWithCategoryListExcelViewModelsAsync();
    }
}
