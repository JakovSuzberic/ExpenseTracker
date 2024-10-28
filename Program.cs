using ExpenseTracker.Data;
using ExpenseTracker.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(sgo =>
{ // sgo je instanca klase SwaggerGenOptions


    // SECURITY

    sgo.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Autorizacija radi tako da se prvo na ruti /api/v1/Autorizacija/token.  
                          autorizirate i dobijete token (bez navodnika). Upišite 'Bearer' [razmak] i dobiveni token.
                          Primjer: 'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYmYiOjE2OTc3MTc2MjksImV4cCI6MTY5Nzc0NjQyOSwiaWF0IjoxNjk3NzE3NjI5fQ.PN7YPayllTrWESc6mdyp3XCQ1wp3FfDLZmka6_dAJsY'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    sgo.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,

            },
         new List<string>()
        }
    });

    // END SECURITY

});


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


//security
// https://www.youtube.com/watch?v=mgeuh8k3I4g&ab_channel=NickChapsas
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.TokenValidationParameters = new TokenValidationParameters
    {
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MojKljucKojijeJakoTajan i dovoljno duga?ak da se može koristiti")),
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = false
    };
});
builder.Services.AddAuthorization();
// endsecurity

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

    // SECURITY
    app.UseAuthentication();
    // ENDSECURITY

    app.UseAuthorization();

    app.MapControllers();

    app.UseCors("CorsPolicy");

    app.Run();

