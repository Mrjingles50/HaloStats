using HaloStats.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient<HaloAPIClient>("base", client =>
{
    client.BaseAddress = new Uri($"{HaloAPIConnectionUtils.HostAddress}");
    client.DefaultRequestHeaders.Add("Authorization", "Cryptum-Token AXdEwzSXKHdg2XmMnjsjluT2d5Jgs7HRbzsTdrDzKdXqIPerC7n9QjqFQQam72Dr");
    //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
    //client.DefaultRequestHeaders.Add("Cryptum-API-Version", "2.3-alpha");
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
