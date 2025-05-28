

using LibraryManagementSys.Extensions;
using LibraryManagementSys.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

public class Program
{



    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.WebHost.ConfigureKestrel(serverOptions =>
        {
            serverOptions.ListenAnyIP(5000);//HTTP
            serverOptions.ListenAnyIP(5001, listenOptions =>
                {
                    listenOptions.UseHttps();//HTTPS
                });
        });



        // Add services to the container.
        builder.Services.AddControllers();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


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
        builder.Services.AddAuthorization();

        builder.Services.AddScoped<AuthProviderService>();




        var app = builder.Build();

        // Register custom middleware early in the pipeline


        //app.UseRequestLogging(); //Your custom middleware



        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }



        //app.UseHttpsRedirection();
        app.UseAuthentication();
        app.UseAuthorization();



        app.MapControllers();

        app.Run();
    }
}