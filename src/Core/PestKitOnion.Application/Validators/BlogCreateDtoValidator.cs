using FluentValidation;
using PestKitOnion.Application.DTOs.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnion.Application.Validators
{
    public class BlogCreateDtoValidator:AbstractValidator<BlogCreateDto>
    {
        public BlogCreateDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(50).MinimumLength(3);
        }
    }
}
