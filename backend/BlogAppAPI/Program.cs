using BlogAppAPI.Data;
using BlogAppAPI.Entity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//dbcontext service with the help of dependence injection.
var ConnectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConnectionString));
//add Dependenct injection for generaic repositry and specfic repositry
//========For Blog entity=====================
builder.Services.AddScoped<IRepository<Blog>, SqlRepository<Blog>>();
//========For Category entity=====================
builder.Services.AddScoped<IRepository<Category>, SqlRepository<Category>>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors(op => op.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.Run();
