using MongoDBProject.Dtos.CustomerDtos;

namespace MongoDBProject.Services.CustomerServices
{
    public interface ICustomerService
    {
        Task<List<ResultCustomerDto>> GetAllCustomerAsync();
        Task CreateCustomerAsync(CreateCustomerDto customerDto);
        Task UpdateCustomerAsync(UpdateCustomerDto customerDto);
        Task DeleteCustomerAsync(string id);
        Task<GetByIdCustomerDto> GetByIdCustomerAsync(string id);
    }
}
