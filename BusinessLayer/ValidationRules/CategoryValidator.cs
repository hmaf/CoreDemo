using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
public    class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("لطفا نام را پر کنید")
                .MaximumLength(50).WithMessage("نمی توانید بیشتر از 50 کاراکتر استفاده کنید")
                .MinimumLength(2).WithMessage("نام باید از 2 کارکتر بزرگتر باشد");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("لطفا توضیحات را پر کنید");
        }
    }
}
