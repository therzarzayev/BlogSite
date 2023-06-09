﻿using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.Validation
{
	public class BlogValidator: AbstractValidator<Blog>
	{
		public BlogValidator()
		{
			RuleFor(x=>x.Title).NotEmpty().WithMessage("Mövzu tələb olunur")
				.MinimumLength(5).WithMessage("Mövzu minimum 5 simvollu olmalıdır");
			RuleFor(x => x.Content).NotEmpty().WithMessage("Məzmun tələb olunur")
				.MinimumLength(160).WithMessage("Mövzu minimum 160 simvollu olmalıdır");
			RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kateqoriya tələb olunur");
			RuleFor(x => x.Image).NotEmpty().WithMessage("Şəkil tələb olunur");
		}
	}
}
