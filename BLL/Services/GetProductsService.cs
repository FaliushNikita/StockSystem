using BLL.ServiceContracts;
using DAL.Entities;
using DAL.Repositories;

namespace BLL.Services;

public class GetProductsService : IGetProductService
{
    private readonly IProductRepository _productRepository;
    public GetProductsService()
    {
        _productRepository = new ProductRepository();
    }

    public List<Product> GetAllProducts()
    {
        return _productRepository.GetAll();
    }

    public Product GetById(Guid id)
    {
        return _productRepository.GetById(id);  
    }
}
