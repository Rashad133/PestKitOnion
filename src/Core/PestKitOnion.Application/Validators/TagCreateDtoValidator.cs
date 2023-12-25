using FluentValidation;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.Validators
{
    public class TagCreateDtoValidator:AbstractValidator<Tag>
    {
        public TagCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name important").MaximumLength(20).WithMessage("Max length 20").MinimumLength(3);
        }
    }
}
