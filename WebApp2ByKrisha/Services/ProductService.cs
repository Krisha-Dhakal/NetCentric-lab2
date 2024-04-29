using WebApp2ByKrisha.Models;
namespace WebApp2ByKrisha.Services
{
    public class ProductService : IProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel {Id = 1, Name = "Pen Drive" },
                new ProductViewModel {Id = 2, Name = "Headphone" },
                new ProductViewModel {Id = 3, Name = "Iphone" },
                new ProductViewModel {Id = 4, Name = "Ipad" },
                new ProductViewModel {Id = 5, Name = "Laptop" } ,
            };
        }
    }
}
