using DAL.Entities;

namespace BLL.ServiceContracts;

public interface IGetProductService
{
    public List<Product> GetAllProducts();

    public Product GetById(Guid id);
}
