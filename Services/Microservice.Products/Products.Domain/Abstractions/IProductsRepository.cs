﻿using Products.Domain.Entities;

namespace Products.Domain.Abstractions
{
    public interface IProductsRepository
    {
        Task<IReadOnlyCollection<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(Guid id);
        Task CreateAsync(Product product);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Product product);

    }
}
