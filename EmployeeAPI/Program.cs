
using AppAPI.Repository.Repos;
using AppAPI.Repository.Service;
using AppData.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<EmployeeDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("Data Source=DESKTOP-35VIVUJ;Initial Catalog=EmployeeManagement02;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IAttendanceRepos, AttendanceRepos>();
            builder.Services.AddScoped<IDepartmentRepos, DepartmentRepos>();
            builder.Services.AddScoped<IEmployeeRepos, EmployeeRepos>();
            builder.Services.AddScoped<IPositionRepos, PositionRepos>();
            builder.Services.AddScoped<ISalaryBonusRepos, SalaryBonusRepos>();

            builder.Services.AddScoped<ISalaryBonusService, SalaryBonusService>();
            builder.Services.AddScoped<IEmployeeService,  EmployeeService>();
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
        }
    }
}
