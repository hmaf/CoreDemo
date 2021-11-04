using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(b => b.BlogTitle).NotEmpty().WithMessage("لطفا عنوان را پر کنید")
                .MaximumLength(150).WithMessage("نمی توانیید بیشتر از 150 کارکتر وارد کنید")
                .MinimumLength(4).WithMessage("نمی توانید کمتر از 4 کارکتر وارد کنید");
            RuleFor(b => b.BlogContent).NotEmpty().WithMessage("لطفا محتوای بلوگ را وارد کنید")
                .MinimumLength(4).WithMessage("نمی توانید کمتر از 4 کارکتر وارد کنید");;
            RuleFor(b => b.BlogThumbnailName).NotEmpty().WithMessage("لطفا عکس دوره را پر کنید");
            RuleFor(b => b.CategoryId).NotEmpty().WithMessage("لطفا دسته بندی را پر کنید");
        }
    }
}
