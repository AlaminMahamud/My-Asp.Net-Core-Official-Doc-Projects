
/// Install Nuget Packages

    /// Install-Package Swashbuckle -Pre

/// Add Swashbuckle to project.json

    /// "Swashbuckle": "6.0.0-*"


///
/// 
/// Adding and Configuring Swashbuckle to the middleware

public void ConfigureServices(IServiceCollection services)
{
    // Add Framework services
    services.AddMvc();

    services.AddLogging();

    // Add Our Repository Type
    services.AddSingleton<IToDoRepository, ToDoRepository>();

    // Inject an Implementation of ISwaggerProvider with defaulted settings applied
    services.AddSwaggerGen();
}

public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
{
     app.UseMvcWithDefaultRoute();

      // Enable middleware to serve generated Swagger as a JSON endpoint
      app.UseSwagger();

      // Enable middleware to serve swagger-ui assets (HTML, JS, CSS etc.)
      app.UseSwaggerUi();
}