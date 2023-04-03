using Products.Persistence;
using Products.Application;
using Products.Api.GraphQL.Schemas;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using MediatR;
using System.Reflection;
using System;
using Projects.Api.Filters;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Products.Application.Features.Users.Commands.CreateUser;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices();

//builder.Services.AddTransient<ProductDbContext>(provider => provider.GetService<ProductDbContext>());
builder.Services.AddTransient(provider => provider.GetService<ProductDbContext>());

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

//GraphQL
builder.Services.AddScoped<AppSchema>();

builder.Services.AddGraphQL()
    .AddSystemTextJson()
  .AddGraphTypes(typeof(AppSchema), ServiceLifetime.Scoped);




builder.Services
    .AddControllers(options => options.Filters.Add(typeof(ValidationFilter)))
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateUserCommandValidator>());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



#region ADICIONANDO LOGIN

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "DevFreela.API",
        Version = "v1",
        Description = "Repository developed during the ASP .NET Core Training course maintained by the company Luis Dev. In this project, concepts of development of Web APIs using .NET 6, Clean Architecture, CQRS, Entity Framework Core, Dapper, Repository Pattern, Unit Tests, Authentication and Authorization with JWT, Messaging and Microservices were applied."
    });

    //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

    //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

    //c.IncludeXmlComments(xmlPath);

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header usando o esquema Bearer."
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                 {
                     {
                           new OpenApiSecurityScheme
                             {
                                 Reference = new OpenApiReference
                                 {
                                     Type = ReferenceType.SecurityScheme,
                                     Id = "Bearer"
                                 }
                             },
                             new string[] {}
                     }
                 });
});

#region PARA ADICIONAR AUTENTICAÇÃO

builder.Services
  .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
  .AddJwtBearer(options =>
  {
      options.TokenValidationParameters = new TokenValidationParameters
      {
          ValidateIssuer = true,
          ValidateAudience = true,
          ValidateLifetime = true,
          ValidateIssuerSigningKey = true,

          ValidIssuer = builder.Configuration["JWT:Issuer"],
          ValidAudience = builder.Configuration["JWT:Audience"],
          IssuerSigningKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))
      };
  });

#endregion

#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseAuthentication();

app.UseAuthorization();


app.UseGraphQL<AppSchema>("/graphal");
//app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());
app.UseGraphQLPlayground();


app.MapControllers();

app.Run();
