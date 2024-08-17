using ETicaretAPI.Application.Validators.Products;
using ETicaretAPI.Infrastructure.Filters;
using ETicaretAPI.Persistence;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPersistenceService();
// Add services to the container.
builder.Services.AddCors(options => options.AddDefaultPolicy(policy=>policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod()));
 
builder.Services.AddControllers(options=>options.Filters.Add<ValidationFilters>())
    .AddFluentValidation(fv =>
    {
        // Validator'larý Assembly'den ekleyin
        fv.RegisterValidatorsFromAssemblyContaining<CreateProductValidator>();
        // Diðer FluentValidation konfigürasyonlarý
        // Örneðin: fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
    }); 
builder.Services.AddValidatorsFromAssemblyContaining<CreateProductValidator>(ServiceLifetime.Transient);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(options => options.LowercaseUrls = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
