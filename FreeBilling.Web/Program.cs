var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
app.MapRazorPages();

app.Run(async ctx =>
{
    await ctx.Response.WriteAsync("Welcome to FreeBilling!");
});

app.Run();