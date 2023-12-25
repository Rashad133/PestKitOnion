using FluentValidation;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.Validators
{
    public class PositionCreateDtoValidator:AbstractValidator<Position>
    {
        public PositionCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name important").MaximumLength(20).WithMessage("Max length 20").MinimumLength(3);
        }
    }
}
