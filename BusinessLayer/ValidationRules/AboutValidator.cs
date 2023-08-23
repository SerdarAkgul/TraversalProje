using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("boş olmaz");
            RuleFor(x => x.Image1).NotEmpty().WithMessage ("Lütfen görsel seçini<");
            RuleFor(x => x.Description).NotEmpty().WithMessage("lütfen en az 50 karakterlik açıklama !!!");


        }
    }
}
