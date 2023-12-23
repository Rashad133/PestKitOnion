using FluentValidation;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.Validators
{
    internal class TagCreateDtoValidator:AbstractValidator<Tag>
    {
        public TagCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name important").MaximumLength(20).WithMessage("Max length 30").MinimumLength(3);
        }
    }
}
