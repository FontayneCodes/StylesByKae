using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DemoHairSite.Models;
using DemoHairSite.Data;

namespace DemoHairSite.Pages
{
    public class BookingModelPage : PageModel
    {
        private readonly ApplicationDbContext _context;

        public BookingModelPage(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BookingModel Booking { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Bookings.Add(Booking);
            _context.SaveChanges();

            return RedirectToPage("ThankYou"); // you can add this page later
        }
    }
}
