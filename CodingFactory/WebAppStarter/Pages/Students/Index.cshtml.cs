using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter.Models;

namespace WebAppStarter.Pages.Students
{
    public class IndexModel : PageModel
    {

        public List<Student> Students { get; set; } = null!;

        public IActionResult OnGet()
        {
            ViewData["Title"] = "Coding Factory - Students";

            if (Request.Query.TryGetValue("lastname", out var lastname))
            {
                if (lastname == "Alonso")
                {
                    Students = new List<Student>()
                    {
                        new Student { Id = 1, Firstname = "Fernando", Lastname = "Alonso" }
                    };
                }
                return Page();
            }

            Students = new List<Student>()
            {
                new Student { Id = 1, Firstname = "Fernando", Lastname = "Alonso" },
                new Student { Id = 2, Firstname = "Oscar", Lastname = "Piastri" },
                new Student { Id = 3, Firstname = "Daniel", Lastname = "Ricciardo" }
            };

            return Page();
        }
    }
}
