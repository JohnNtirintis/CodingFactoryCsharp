using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter.DTO;
using WebAppStarter.Models;

namespace WebAppStarter.Pages.Students
{
    public class StudentModel : PageModel
    {

        public StudentReadOnlyDTO StudentReadOnlyDTO { get; set; } = null!;

        public void OnGet(int id)
        {
            Student student = new()
            {
                Id = 1,
                Firstname = "Pierre",
                Lastname = "Gasly"
            };

            StudentReadOnlyDTO = new StudentReadOnlyDTO
            {
                Id = student.Id,
                Firstname = student.Firstname,
                Lastname = student.Lastname
            };
        }
    }
}
