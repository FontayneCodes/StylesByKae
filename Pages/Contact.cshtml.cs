using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DemoHairSite.Models;
using DemoHairSite.Data;

namespace DemoHairSite.Pages
{
    public class ContactPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ContactPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ContactModel ContactForm { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Contacts.Add(ContactForm);
            _context.SaveChanges();

            return RedirectToPage("ThankYou"); // or return Page(); if no thank you yet
        }
    }
}
