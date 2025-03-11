using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidatior:AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("You cannot leave the category name empty.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Please enter at least 3 characters.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("You cannot skip the description.");
        }
    }
}
