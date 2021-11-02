using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            Regex regex = new Regex(@"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])");

            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı kısmı boş geçilemez!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez!")
                .Matches(regex).WithMessage("Şifre en az 1 tane büyük, küçük harf ve rakam içermelidir. ")
                .MinimumLength(8).WithMessage("Şifre en az 8 karakter olmalı.");
                ;
            RuleFor(x => x.ConfirmWriterPassword).NotEmpty().WithMessage("Şifre tekrarı boş bırakılamaz!");
            RuleFor(x => x.WriterPassword).Equal(x => x.ConfirmWriterPassword).WithMessage("Şifreler eşleşmiyor");
            RuleFor(x => x.WriterImage).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın!");

            RuleFor(x => x.WriterName).MaximumLength(50)
                .WithMessage("Lütfen en fazla 50 karakterlik veri girşi yapın!");
        }
    }
}
