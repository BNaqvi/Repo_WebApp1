var builder = WebApplication.CreateBuilder(args);

// Add services to the container.  // Add services to the container. (duplicated locally to push on git)
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline. // Configure the HTTP request pipeline.(replicated at git online)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
