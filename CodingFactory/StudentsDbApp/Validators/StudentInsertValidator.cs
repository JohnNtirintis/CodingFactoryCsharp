using FluentValidation;
using StudentsDbApp.DTO;

namespace StudentsDbApp.Validators
{
    public class StudentInsertValidator : AbstractValidator<StudentInsertDTO>
    {
        public StudentInsertValidator()
        {
            RuleFor(s => s.Firstname).NotEmpty()
                .WithMessage("The field 'Firstname' cant be empty")
                .Length(2, 255)
                .WithMessage("The field 'Firstname' must be between 2-255");
            RuleFor(s => s.Lastname).NotEmpty()
                .WithMessage("The field 'Lastname' cant be empty.")
                .Length(2, 255)
                .WithMessage("The field 'Lastname' must be between 2-255");
        }
    }
}
