﻿using MongoDBProject.Dtos.CustomerDtos;
using MongoDBProject.Dtos.ProductDtos;

namespace MongoDBProject.Dtos.OrderDtos
{
    public class ResultOrderWithCustomerWithProductDto
    {
        public string OrderId { get; set; }
        public int OrderProductPiece { get; set; }
        public DateTime OrderDate { get; set; }
        public string? CustomerId { get; set; }
        public ResultCustomerDto Customer { get; set; }
        public string? ProductId { get; set; }
        public ResultProductDto Product { get; set; }
    }
}