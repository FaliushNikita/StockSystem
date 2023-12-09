using BLL.ServiceContracts;
using DAL.Entities;
using DAL.Repositories;

namespace BLL.Services;

public class AddProductService : IAddProductService
{
    private readonly IProductRepository _productRepository;
    public AddProductService()
    {
        _productRepository = new ProductRepository();
    }

    public Product AddProduct(Product product)
    {
        _productRepository.Insert(product);

        return product;
    }
        
    
}
