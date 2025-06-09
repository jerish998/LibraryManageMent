

using LibraryManagementSys.DbContextApp;
using LibraryManagementSys.Extensions;
using LibraryManagementSys.Services;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using System.Xml.Linq;
using Unity;
using Unity.Microsoft.DependencyInjection;
using Microsoft.EntityFrameworkCore;


public class Program
{



    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //  Register your services
        builder.Services.AddScoped<IAuthProviderService, AuthProviderService>();
        builder.Services.AddScoped<IUserService, UserService>();
        // Add controllers (for Web API)

        builder.Services.AddControllers();

        // Add Swagger if needed (optional)
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddAuthorization();

        /*jwt tokens*/
        var jwtSettings = builder.Configuration.GetSection("Jwt");

        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.RequireHttpsMetadata = false; // true in production
            options.SaveToken = false;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = false,
                ValidateIssuerSigningKey = false,
                ValidIssuer = jwtSettings["Issuer"],
                ValidAudience = jwtSettings["Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(jwtSettings["Key"]))
            };
        });
        /*end jwt tokens*/

        builder.WebHost.ConfigureKestrel(serverOptions =>
        {
            serverOptions.ListenAnyIP(5000);//HTTP
            serverOptions.ListenAnyIP(5001, listenOptions =>
            {
                listenOptions.UseHttps();//HTTPS
            });
        });

        builder.Services.AddDbContext<DbConnectionAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));




        var app = builder.Build();

        // Middleware pipeline
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseRouting();

        app.UseAuthorization();
        app.UseAuthentication();
        app.MapControllers();

        app.Run();

    }



}