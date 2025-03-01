using Microsoft.AspNetCore.Mvc;
using MyAspNetApp.Data;
using MyAspNetApp.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MyAspNetApp.Controllers
{
    public class ProductsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductsController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _context.Products.ToListAsync();
        return View(products);
    }
}
}

