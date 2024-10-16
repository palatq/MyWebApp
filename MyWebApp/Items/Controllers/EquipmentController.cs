using Microsoft.AspNetCore.Mvc;
using MyWebApp.Items.Data;
using MyWebApp.Models;
using System.Linq;

namespace MyWebApp.Items.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly MyDbContext _context;

        public EquipmentController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var equipments = _context.Equipments.ToList();
            return View(equipments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Equipment equipment)
        {
            if (ModelState.IsValid)
            {
                _context.Equipments.Add(equipment);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(equipment);
        }
    }
}
