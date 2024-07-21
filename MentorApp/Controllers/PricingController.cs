using MentorApp.Data;
using MentorApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.Controllers
{
    public class PricingController : Controller
    {
        private readonly MentorAppDbContext _context;

        public PricingController(MentorAppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            PricingVM pricingVM = new();
            pricingVM.Pricings = _context.Pricings
                .Include(p=>p.PricingServices)
                .ThenInclude(pc=>pc.Service)
                .ToList();
            pricingVM.Services = _context.Services.ToList();
            return View(pricingVM);
        }
    }
}
