public void ConfigureServices(IServiceCollection services)
{
    // Add Framework Services.
    services.AddDbContext<ApplicationDbContext>(options => 
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")))
}

public void Configure()
{
    SeedData.Initialize(app.ApplicationServices); 
}