using FluentValidation;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.Validators
{
    internal class PositionCreateDtoValidator:AbstractValidator<Position>
    {
        public PositionCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name important").MaximumLength(20).WithMessage("Max length 30").MinimumLength(3);
        }
    }
}
