using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Validators;

namespace BusinessLayer.Validation
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.FirstName).NotEmpty().WithMessage("Ad tələb olunur")
				.MaximumLength(50).WithMessage("Ad 50 simvoldan uzun ola bilməz");
			RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyad tələb olunur")
				.MaximumLength(50).WithMessage("Soyad 50 simvoldan uzun ola bilməz");
			RuleFor(x => x.Email).NotEmpty().WithMessage("Email tələb olunur")
				.EmailAddress(EmailValidationMode.AspNetCoreCompatible).WithMessage("Email düzgün deyil");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Parol tələb olunur")
				.MinimumLength(6).WithMessage("Parolun uzunluğu 5-dən çox olmalıdır")
				.MaximumLength(50).WithMessage("Parol 50 simvoldan uzun ola bilməz")
				.Matches(@"^(?=.*[A-Z]).+$")
				.WithMessage("Parolda ən azı bir böyük hərf olmalıdır")
				.Matches(@"^(?=.*[a-z]).+$")
				.WithMessage("Parolda ən azı bir kiçik hərf olmalıdır")
				.Matches(@"^(?=.*[^\w\s]).+$")
				.WithMessage("Parolda ən azı bir xüsusi simvol olmalıdır")
				.Matches(@"^(?=.*\d).+$")
				.WithMessage("Parolda ən azı bir rəqəm olmalıdır");
		}
	}
}
