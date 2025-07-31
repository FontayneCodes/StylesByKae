using Microsoft.AspNetCore.Mvc.RazorPages;
using DemoHairSite.Models;
using DemoHairSite.Data;
using System.Collections.Generic;
using System.Linq;

namespace DemoHairSite.Pages
{
    public class ServicesPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ServicesPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ServicesModel> ServicesList { get; set; }

        public void OnGet()
        {
            ServicesList = _context.Services.ToList();
        }
    }
}
