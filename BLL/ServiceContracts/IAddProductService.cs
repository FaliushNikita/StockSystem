using DAL.Entities;

namespace BLL.ServiceContracts;

public interface IAddProductService
{
    public Product AddProduct(Product product);
}
