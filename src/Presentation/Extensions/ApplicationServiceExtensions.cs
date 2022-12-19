using System.Globalization;
using System.Reflection;
using Application.Interfaces;
using Application.Mapper;
using Infrastructure.Persistence.Data;
using Infrastructure.Persistence.Interceptors;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Presentation.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        WebApplicationBuilder builder)
    {
        builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        builder.Services.AddScoped<AuditableEntityInterceptor>();
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddDbContext<AppDbContext>(
            (sp, optionsBuilder) =>
            {
                var auditableInterceptor = sp.GetService<AuditableEntityInterceptor>()!;
                optionsBuilder.UseSqlServer(
                        builder.Configuration.GetConnectionString("DefaultConnection"),
                        opt =>
                        {
                            opt.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext))!.GetName().Name
                            );
                        }
                    )
                    // ReSharper disable once HeapView.ObjectAllocation
                    .AddInterceptors(auditableInterceptor)
                    ;
            } //, ServiceLifetime.Transient
        );


        var logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.Debug(outputTemplate: DateTime.Now.ToString(CultureInfo.InvariantCulture))
            //.WriteTo.Seq("http://localhost:5341", apiKey: "slMx1CIEqk77CjCPCgZe", controlLevelSwitch: new LoggingLevelSwitch())
            .WriteTo.File("/ilvi/log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        builder.Logging.ClearProviders();
        builder.Logging.AddSerilog(logger);
        Console.WriteLine("Hello Serilog");
        //  builder.Services.AddHangfire(_ =>
        //      _.UseSqlServerStorage(builder.Configuration.GetConnectionString("HangFireDbConnection"),
        //          new SqlServerStorageOptions { PrepareSchemaIfNecessary = true }));
        // builder.Services.AddHangfireServer();
        builder.Services.AddAutoMapper(typeof(MapProfile));
      //  builder.Services.AddMicrosoftIdentityWebApiAuthentication(builder.Configuration);

        return services;
    }
}