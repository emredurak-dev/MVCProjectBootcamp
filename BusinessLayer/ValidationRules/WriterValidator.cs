using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {

        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("You cannot leave the writer name empty.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("You cannot leave the writer surname empty.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("You cannot skip the about.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("You cannot leave the writer title empty.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("You cannot leave the writer mail empty.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("You cannot leave the writer password empty.");
        }
    }
}
