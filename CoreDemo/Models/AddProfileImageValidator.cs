using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CoreDemo.Models;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AddProfileImageValidator:AbstractValidator<AddProfileImageViewModel>
    {
        public AddProfileImageValidator()
        {
            RuleFor(w => w.WriterName).NotEmpty().WithMessage("لطفا نام را پر کنید")
                .MinimumLength(2).WithMessage("نام نمی تواند کمتر از دو کاراکتر باشد")
                .MaximumLength(50).WithMessage("نام نمی تواند بیشتر از پنجاه کارکتر باشد");
            RuleFor(w => w.WriterMail).NotEmpty().WithMessage("لطفا ایمیل را وارد کنید")
                .EmailAddress().WithMessage("لطفا ایمیل را درست وارد کنید");
            RuleFor(w => w.WriterPassword).NotEmpty().WithMessage("لطفا کلمه عبور را وارد کنید")
                .Must(w=>hasValidPassword(w)).WithMessage("کلمه عبور باید یک کاراکتر بزرگ و کوچک و رقم باشد");
        }

        private static bool hasValidPassword(string password)
        {
            var lowercase = new Regex("[a-z]+");
            var uppercase = new Regex("[A-Z]+");
            var digit = new Regex("(\\d)+");
            //var symbol = new Regex("(\\W)+");
            return lowercase.IsMatch(password) &&
                   uppercase.IsMatch(password) &&
                   digit.IsMatch(password);
        }
    }
}
