using ApsnetCoreMVC.Models;
using ApsnetCoreMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApsnetCoreMVC.Controllers
{
    public class FattureController : Controller
    {
        readonly ApplicationDbContext _context;

        public FattureController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            List<Fattura> fattura = _context.Fatture.OrderByDescending(classeFattura => classeFattura.FatturaId).ToList();

            return View(fattura);
        }


        public IActionResult Create() => View();
    }
}
