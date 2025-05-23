using Library.ApplicationCore;
using Library.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appSettings.json")
    .Build();

services.AddSingleton<IConfiguration>(configuration);

services.AddScoped<IPatronRepository, JsonPatronRepository>();
services.AddScoped<ILoanRepository, JsonLoanRepository>();
services.AddScoped<ILoanService, LoanService>();
services.AddScoped<IPatronService, PatronService>();

services.AddSingleton<JsonData>();
services.AddSingleton<ConsoleApp>();

var servicesProvider = services.BuildServiceProvider();

var consoleApp = servicesProvider.GetRequiredService<ConsoleApp>();
consoleApp.Run().Wait();
