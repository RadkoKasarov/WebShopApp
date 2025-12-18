using NuGet.Protocol;

using System.ComponentModel.DataAnnotations;

using WebShopApp.Models.Brand;

namespace WebShopApp.Models.Product
{
    public class ProductCreateVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; } = null!;

        [Required]
        [Display(Name = "Brand")]
        public int CategoryId { get; set; }
        public virtual List<BrandPairVM> Categories { get; set; } = new List<BrandPairVM>();


    }
}
