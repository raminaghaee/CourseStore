using CourseStore.BLL.Tags.Commands;
using CourseStore.DAL.DbContexts;
using CourseStore.DAL.Frameworke;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CourseStoreDbCoubtex>(c=>c.UseSqlServer("Server=DESKTOP-7SS5LH0;Initial Catalog =CourseShopDb; User Id =sa ; Password= 123").
    AddInterceptors(new AddAuditFieldInterceptor()));
builder.Services.AddMediatR(typeof(CreateTagHandler).Assembly);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
