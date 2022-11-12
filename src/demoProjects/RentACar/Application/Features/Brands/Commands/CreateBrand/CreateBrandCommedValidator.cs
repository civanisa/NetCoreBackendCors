using FluentValidation;

namespace Application.Features.Brands.Commands.CreateBrand
{
    public class CreateBrandCommedValidator : AbstractValidator<CreateBrandCommend>
    {
        public CreateBrandCommedValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
        }
    }
}
