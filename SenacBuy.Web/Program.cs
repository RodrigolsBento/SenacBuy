using SenacBuy.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Registrar MVC
builder.Services.AddControllersWithViews();

// Session (para armazenar usuário logado)
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(8);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// HttpClient configurado para consumir a API SenacBuy
var apiBaseUrl = builder.Configuration["ApiBaseUrl"] ?? "http://localhost:5000";
builder.Services.AddHttpClient("SenacBuyAPI", client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
    client.Timeout = TimeSpan.FromSeconds(30);
});

// Registrar Services da camada Web
builder.Services.AddScoped<ClienteApiService>();
builder.Services.AddScoped<ProdutoApiService>();
builder.Services.AddScoped<PedidoApiService>();
builder.Services.AddScoped<UsuarioApiService>();
builder.Services.AddScoped<CategoriaApiService>();
builder.Services.AddScoped<DashboardApiService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
