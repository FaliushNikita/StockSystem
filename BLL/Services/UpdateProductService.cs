using BLL.ServiceContracts;
using DAL.Entities;
using DAL.Repositories;

namespace BLL.Services;

public class UpdateProductService : IUpdateProductService
{
    private readonly IProductRepository _repository;

    public UpdateProductService() => _repository = new ProductRepository();
    
    public bool Update(Product product) => _repository.Update(product);
}
