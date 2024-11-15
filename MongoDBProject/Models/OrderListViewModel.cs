using MongoDBProject.Dtos.CustomerDtos;

namespace MongoDBProject.Models
{
    public class OrderListViewModel
    {
        public string OrderProductName { get; set; }
        public string OrderProductPiece { get; set; }
        public string CustomerId { get; set; }
        public ResultCustomerDto Customer { get; set; }
    }
}
