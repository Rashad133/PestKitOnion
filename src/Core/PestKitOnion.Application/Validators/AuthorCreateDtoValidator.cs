using FluentValidation;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.Validators
{
    public class AuthorCreateDtoValidator:AbstractValidator<Author>
    {
        public AuthorCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name important").MaximumLength(20).WithMessage("Max length 20").MinimumLength(3);
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surame important").MaximumLength(40).WithMessage("Max length 40").MinimumLength(10);
        }
    }
}
