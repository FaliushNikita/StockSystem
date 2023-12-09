using DAL.Entities;

namespace DAL.Repositories;

public interface IProductRepository
{
    List<Product> GetAll();

    Product GetById(Guid id);

    bool Insert(Product product);

    bool Update(Product product);

    bool Delete(Product product);
}
