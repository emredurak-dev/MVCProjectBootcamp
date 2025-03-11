using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("you cant skip receiver mail...");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("you cant skip subject...");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("you cant skip content...");

            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("min 3 char...");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("max 100 char...");
        }

        
    }
}
