using DAL.Entities;

namespace BLL.ServiceContracts;

public interface IDeleteProductService
{
    public bool Delete(Product product);
}
