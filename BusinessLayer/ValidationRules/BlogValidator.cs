﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş bırakamazsınız!");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş bırakamazsınız!");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini boş bırakamazsınız!");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri girişi yapınız!");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lütfen 5 karakterden daha fazla veri girişi yapınız!");
            

        }
    }
}
