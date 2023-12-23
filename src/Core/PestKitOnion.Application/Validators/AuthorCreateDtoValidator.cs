using FluentValidation;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.Validators
{
    internal class AuthorCreateDtoValidator:AbstractValidator<Author>
    {
        public AuthorCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name important").MaximumLength(20).WithMessage("Max length 30").MinimumLength(3);
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surame important").MaximumLength(40).WithMessage("Max length 40").MinimumLength(10);
        }
    }
}
