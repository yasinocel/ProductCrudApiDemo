﻿namespace ProductCrudApi.Models
{
    public record CreateProductRequest(string Name, string Description, decimal Price);
}
