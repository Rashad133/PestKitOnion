using FluentValidation;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.Validators
{
    public class DepartmentCreateDtoValidator:AbstractValidator<Department>
    {
        public DepartmentCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name important").MaximumLength(20).WithMessage("Max length 20").MinimumLength(3);
        }
    }
}
