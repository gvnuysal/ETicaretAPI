using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator:AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(c=>c.Name).NotEmpty()
                              .NotNull()
                              .WithMessage("Lütfen ürün adını giriniz.")
                              .MaximumLength(150)
                              .MinimumLength(3)
                              .WithMessage("Lütfen ürün adını 3-150 karakter arasında giriniz");

            RuleFor(c => c.Stock).NotNull()
                               .NotEmpty()
                               .WithMessage("Lütfen stok bilgisini boş geçmeyiniz.")
                               .Must(m => m >= 0)
                               .WithMessage("Stok bilgisi negatif olamaz");

            RuleFor(c => c.Price).NotNull()
                           .NotEmpty()
                           .WithMessage("Lütfen fiyat bilgisini boş geçmeyiniz.")
                           .Must(m => m >= 0)
                           .WithMessage("Fiyat bilgisi negatif olamaz");

        }
    }
}
