using HomeWorkAnimal.Model;
using HomeWorkAnimal.Repozitory;
using HomeWorkAnimal.Repozitory.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<Animal,Cat>();
builder.Services.AddTransient<Animal, Dog>();
builder.Services.AddTransient<IRepozitory,Repozitory>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
