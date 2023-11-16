using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentsDbApp.Models;
using StudentsDbApp.Services;

namespace StudentsDbApp.Pages.Students
{
    public class DeleteModel : PageModel
    {
        public List<Error> ErrorsArray { get; set; } = new();
        private readonly IStudentService _studentService;

        public DeleteModel(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        public void OnGet(int id)
        {
            try
            {
                Student? student = _studentService?.DeleteStudent(id);
                Response.Redirect("/Students/getall");
            } catch (Exception e)
            {
                ErrorsArray.Add(new Error("", e.Message, ""));
            }
        }
    }
}
