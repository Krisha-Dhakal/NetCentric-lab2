using WebApp2ByKrisha.Models;

namespace WebApp2ByKrisha.Services
{
    public class BetterProductService : IProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel {Id = 1, Name = "Television"
            },
            new ProductViewModel {Id = 2, Name = "Camera" },
            new ProductViewModel {Id = 3, Name = "Printer" },
            new ProductViewModel {Id = 4, Name = "Scanner" },
            new ProductViewModel {Id = 5, Name = "Speaker" } ,
            };
        }
    }
}
