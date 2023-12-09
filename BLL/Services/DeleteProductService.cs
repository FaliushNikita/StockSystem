using BLL.ServiceContracts;
using DAL.Entities;
using DAL.Repositories;

namespace BLL.Services;

public class DeleteProductService : IDeleteProductService
{
    private readonly IProductRepository _repository;

    public DeleteProductService() => _repository = new ProductRepository();
    
    public bool Delete(Product product) => _repository.Delete(product);
    
}
