using Midterm_SamsonIkilama.Model;
using Midterm_SamsonIkilama.Services;


public class SIProductService : ISIProductService
{
    private static List<SIProduct> _products = new()
    {
        new SIProduct { Id = 1, Name = "Laptop", Quantity = 5 },
        new SIProduct { Id = 2, Name = "Mouse", Quantity = 10 },
        new SIProduct { Id = 3, Name = "Keyboard", Quantity = 7 }
    };

    public List<SIProduct> GetAll()
    {
        return _products;
    }

    public SIProduct Add(SIProduct product)
    {
        product.Id = _products.Max(p => p.Id) + 1;
        _products.Add(product);
        return product;
    }
}