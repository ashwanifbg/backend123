using Serilog;
using EFDemo.Services;
using EFDemo.Models;

namespace EFDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<CommentService>();
            builder.Services.AddDbContext<CommentContext>();

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            ////////
            ///log code
            ///

            var logger = new LoggerConfiguration()
            .WriteTo.File("C:/Users/pulkit/source/repos/WebApplication3/CommentsLog/", rollingInterval: RollingInterval.Day)
            .CreateLogger();
            builder.Services.AddSerilog(logger);

            /////////log code end

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}