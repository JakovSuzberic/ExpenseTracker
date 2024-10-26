using ExpenseTracker.Data;
using ExpenseTracker.Mapping;
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

builder.Services.AddCors(options =>
{

    options.AddPolicy("CorsPolicy",
        builder =>
            builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
    );
});

//AutoMapper
builder.Services.AddAutoMapper(typeof(ExpenseTrackerMappingProfile));

var app = builder.Build();




// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI(o =>
    {

        o.ConfigObject.AdditionalItems.Add("requestSnippetEnabled", true);
        o.EnableTryItOutByDefault();

    });
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("CorsPolicy");

app.Run();
