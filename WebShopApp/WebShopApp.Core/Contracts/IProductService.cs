using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using WebShopApp.Infrastructure.Data.Domain;

namespace WebShopApp.Core.Contracts
{
    public interface IProductService
    {
<<<<<<< HEAD
        bool Create(string name, int brandId, int categoryId, string picture, int quantity, decimal price, decimal discount);
=======
        bool Create(string name, int brandId, string picture, int quantity, decimal price, decimal discount);
>>>>>>> f30f44bdcf686606733ee47de7e21974199bd34c
        bool Update(int productId, string name, int brandId, int categoryId, string picture, int quantity, decimal price, decimal discount);

        List<Product> GetProducts();
        Product GetProductById(int productId);
        bool RemoveById(int productId);
        List<Product> GetProducts(string searchStringCategoryName, string searchStringBrandNAme);

    }
}
