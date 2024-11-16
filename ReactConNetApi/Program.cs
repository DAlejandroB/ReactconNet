using Microsoft.EntityFrameworkCore;
using ReactConNetApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<SocialMediaContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();
