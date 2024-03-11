using DemoApp;
using Microsoft.Extensions.DependencyInjection;

/**
 * Setup
 */
// Add service provider to console application
var serviceProvider = new ServiceCollection()
    .AddScoped<IScopedService, ScopedService>()
    .BuildServiceProvider();


/**
 * Start
 */
using var scope = serviceProvider.CreateScope();
var scopedService = scope.ServiceProvider.GetRequiredService<IScopedService>();

// Uncomment the below 2 lines if you want to pause before starting the demo
//Console.WriteLine("Press the Enter key to start...");
//Console.ReadLine(); 


/** 
 * String Concatenation Demo 
 */
//Helpers.ConcatStrings();


/** 
 * * AsyncVoid Demo 
 * */
//scopedService.DoSomethingAsync();



