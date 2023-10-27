namespace GuitarShop.Models
{
    public class ProductsViewModel
    {
        public List<Category> Categories { get; set; } = null!;
        public List<Product> Products { get; set; } = null!;
        public string SelectedCatagory { get; set; } = string.Empty;
        public string CheckActiveCategory(string category) => category == SelectedCatagory ? "active" : "";
    }
}
