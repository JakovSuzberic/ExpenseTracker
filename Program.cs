using ExpenseTracker.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add database
builder.Services.AddDbContext<ExpenseTrackerContext>(options =>
{

    options.UseSqlServer(builder.Configuration.GetConnectionString("ExpenseTrackerContext"));

});

var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(o =>
    {

        o.ConfigObject.AdditionalItems.Add("requestSnippetEnabled", true);
        o.EnableTryItOutByDefault();

    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
