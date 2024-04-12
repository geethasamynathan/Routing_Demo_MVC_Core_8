var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
//.Net Core upto 5.0
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//        name: default,
//        pattern: "{controller=Home}/{action=Index" /{ id ?} ");
//});
//convetional Routing
//app.MapControllerRoute(
//    name: "blog",
//    pattern: "blog/{*Article}",
//    defaults: new { controller = "Blog", action = "Article" }
//    );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
