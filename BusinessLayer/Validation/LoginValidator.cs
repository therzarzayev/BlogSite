
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Validators;

namespace BusinessLayer.Validation
{
	public class LoginValidator: AbstractValidator<Writer>
	{
        public LoginValidator()
        {
			RuleFor(x => x.Email).NotEmpty().WithMessage("Email tələb olunur")
				.EmailAddress(EmailValidationMode.AspNetCoreCompatible).WithMessage("Email düzgün formatda deyil");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Parol tələb olunur");

		}
    }
}
