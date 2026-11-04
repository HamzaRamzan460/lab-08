
using hamza.Data;
using hamza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hamza.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductRepository _repository;

        public IndexModel(ProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> Products { get; set; } = new();

        public async Task OnGetAsync()
        {
            Products = await _repository.GetAllAsync();
        }
    }
}
