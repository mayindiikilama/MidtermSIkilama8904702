using Midterm_SamsonIkilama.Model;

namespace Midterm_SamsonIkilama.Services
{

    public interface ISIProductService
    {
        List<SIProduct> GetAll();
        SIProduct Add(SIProduct product);
    }
}
