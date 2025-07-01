using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Portfolio;
using Portfolio.Services;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddRadzenComponents();

builder.Services.AddRadzenCookieThemeService(options =>
{
    options.Name = "TesteRadzenTheme";
    options.Duration = TimeSpan.FromDays(365);
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IPersonalService, PersonalService>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<IEducationService, EducationService>();
builder.Services.AddScoped<IProfessionalExperienceService, ProfessionalExperienceService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IQualificationService, QualificationService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IStackService, StackService>();

await builder.Build().RunAsync();
