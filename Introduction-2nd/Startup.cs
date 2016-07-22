namespace Introduction-2nd
{
    public class Startup
    {
        // This method gets called by RUNTIME
        // Use this method to add Services to the container
        public void ConfigureServices(IServiceCollection services)
        {

        }

        //This method gets called by RUNTIME
        //Use this method to Handle The HTTP Request Pipeline
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async(context)=>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}