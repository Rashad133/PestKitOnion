using FluentValidation;
using PestKitOnion.Application.DTOs.Employee;

namespace PestKitOnion.Application.Validators
{
    public class EmployeeCreateDtoValidator:AbstractValidator<EmployeeCreateDto>
    {
        public EmployeeCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50).MinimumLength(3);
            RuleFor(x => x.Surname).NotEmpty().MaximumLength(50).MinimumLength(3);
        }
    }
}
