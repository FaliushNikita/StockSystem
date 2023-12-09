using DAL.Base;
using DAL.Entities;

namespace DAL.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context = new ApplicationDbContext();

    public bool Delete(Product product)
    {
        try
        {
            _context.Products.Remove(product);
            _context.SaveChanges();

            return true;
        }
        catch 
        {
            throw;
        }
    }

    public List<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    public Product GetById(Guid id)
    {
        return _context.Products.First(x => x.Id == id);
    }

    public bool Insert(Product product)
    {
        try
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            throw;
        }

        
    }

    public bool Update(Product product)
    {
        try
        {
            _context.Products.Update(product);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            throw;
        }
    }
}
