using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Presentation.Extensions;
using Presentation.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices(builder);

// var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
//
// builder.Services.AddCors(options =>
// {
//     options.AddPolicy(MyAllowSpecificOrigins,
//         policy =>
//         {
//             policy.WithOrigins("http://localhost:5173"); // add the allowed origins
//         });
// });
builder.Services.AddCors(opt => opt.AddPolicy("CorsPolicy",
    policy => policy
        .AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed(origin=> true)
        .AllowCredentials()
    
    // .WithOrigins(builder.Configuration.GetSection("WebUri").Value)
));

var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();

app.UseSwagger();
app.UseSwaggerUI();
app.UseStatusCodePagesWithReExecute("/errors{0}");



// Configure the HTTP request pipeline.
using (var scope = app.Services.CreateScope())
{
    try
    {
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        await context.Database.MigrateAsync();
    }
    catch (Exception e)
    {
        Console.WriteLine(e + "An error occured during migration");
    }
}



// BackgroundJob.Enqueue(() => Console.WriteLine("Hello world from Hangfire!"));
// app.UseHttpsRedirection();
app.UseCors("CorsPolicy");

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();