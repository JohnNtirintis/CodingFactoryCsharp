using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentsDbApp.DTO;
using StudentsDbApp.Models;
using StudentsDbApp.Services;

namespace StudentsDbApp.Pages.Students
{
    public class CreateModel : PageModel
    {

        public List<Error> ErrorsArray { get; set; } = new();
        public StudentInsertDTO StudentInsertDTO { get; set; } = new();

        private readonly IStudentService? _studentService;
        private readonly IValidator<StudentInsertDTO> _studentInsertValidator;

        public CreateModel(IStudentService? studentService, IValidator<StudentInsertDTO> studentInsertValidator)
        {
            _studentService = studentService;
            _studentInsertValidator = studentInsertValidator;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public void OnPost(StudentInsertDTO dto)
        {
            // When submit is clicked and page is refreshed,
            // the text-boxes retain the old values through StudentInsertDTO
            StudentInsertDTO = dto;

            var validationResult = _studentInsertValidator.Validate(dto);

            if(!validationResult.IsValid)
            {
                foreach(var error in validationResult.Errors)
                {
                    // Error?
                    // ErrorArray!.Add(new Error(error.ErrorCode, error.ErrorMessage, error.PropertyName));
                    ErrorsArray!.Add(new Error(error.ErrorCode, error.ErrorMessage, error.PropertyName));
                }
                return;
            }

            try
            {
                Student student = _studentService?.InsertStudent(dto)!;
                Response.Redirect("/Students/getall");
            } catch (Exception e) 
            {
                ErrorsArray!.Add(new Error("", e.Message, ""));
            }
        }
    }
}
