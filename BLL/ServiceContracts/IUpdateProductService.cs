using DAL.Entities;

namespace BLL.ServiceContracts;

public interface IUpdateProductService
{
    public bool Update(Product product);
}
