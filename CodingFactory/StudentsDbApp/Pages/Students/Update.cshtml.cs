using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentsDbApp.DTO;
using StudentsDbApp.Models;
using StudentsDbApp.Services;

namespace StudentsDbApp.Pages.Students
{
    public class UpdateModel : PageModel
    {
        public StudentUpdateDTO StudentUpdateDTO { get; set; } = new();
        public List<Error> ErrorsArray { get; set; } = new();

        private readonly IStudentService? _studentService;
        private readonly IMapper? _mapper;
        private readonly IValidator<StudentUpdateDTO> _studentUpdateValidator;

        public UpdateModel(IStudentService? studentService, IMapper? mapper, IValidator<StudentUpdateDTO> studentUpdateValidator)
        {
            _studentService = studentService;
            _mapper = mapper;
            _studentUpdateValidator = studentUpdateValidator;
        }

        public IActionResult OnGet(int id)
        {
            try
            {
                Student? student = _studentService?.GetStudent(id);
                StudentUpdateDTO = _mapper!.Map<StudentUpdateDTO>(student);
            } catch (Exception e)
            {
                ErrorsArray.Add(new Error("", e.Message, ""));
            }
            return Page();
        }

        public void OnPost(StudentUpdateDTO dto)
        {
            // Refresh
            StudentUpdateDTO = dto;

            var validationResult = _studentUpdateValidator.Validate(dto);

            if(!validationResult.IsValid)
            {
                ErrorsArray = new();
                foreach(var error in validationResult.Errors)
                {
                    ErrorsArray.Add(new Error(error.ErrorCode, error.ErrorMessage, error.PropertyName));
                }
                return;
            }

            try
            {
                Student? student = _studentService!.UpdateStudent(dto);
                Response.Redirect("/Students/getall");

            } catch (Exception e) 
            {
                ErrorsArray?.Add(new Error("UpdateError", e.Message, e.ToString()));
            }
        }
    }
}
