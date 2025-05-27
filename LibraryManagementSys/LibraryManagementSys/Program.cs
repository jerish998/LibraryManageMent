

using LibraryManagementSys.Extensions;

public class Program
{



    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.WebHost.ConfigureKestrel(serverOptions => {
            serverOptions.ListenAnyIP(5000);//HTTP
            serverOptions.ListenAnyIP(5001,listenOptions => {
                listenOptions.UseHttps();//HTTPS
            });
        });



        // Add services to the container.
        builder.Services.AddControllers();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

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

        //app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}