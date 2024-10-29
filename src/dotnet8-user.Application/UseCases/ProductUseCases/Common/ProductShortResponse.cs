﻿namespace dotnet8_user.Application.UseCases.ProductUseCases.Common
{
    public sealed record ProductShortResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Brand { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
    }
    }