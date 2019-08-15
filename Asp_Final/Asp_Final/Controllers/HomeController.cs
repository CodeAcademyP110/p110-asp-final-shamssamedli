using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp_Final.DAL;
using Asp_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp_Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly CarSaleDbContext _context;

        public HomeController(CarSaleDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            AddView model = new AddView();
            
            model.Brands = _context.Brands.OrderByDescending(m => m.Id).ToList();
            model.Transmissions = _context.Transmissions.ToList();
            model.Makes = _context.Makes.ToList();
            model.Countries = _context.Countries.ToList();
            model.Cities = _context.Cities.ToList();
            model.FuelTypes = _context.FuelTypes.ToList();
            model.Cars = _context.Cars.ToList();
            return View(model);
        }
    }
}