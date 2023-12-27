using FluentValidation;
using PestKitOnion.Application.DTOs.Tag;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.Validators
{
    public class TagCreateDtoValidator:AbstractValidator<TagCreateDto>
    {
        public TagCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name important").MaximumLength(20).WithMessage("Max length 20").MinimumLength(3);
        }
    }
}
