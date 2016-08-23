using System;
public namespace Introduction-2nd
{
   public class Program
   {
       public static void Main()
       {
           var host = new WebHostBuilder()
                      .UseKestrel()
                      .UseContentRoot(Directory.GetCurrentDirectory)
                      .UseStartup<Startup>()
                      .Build();
            host.Run(); 
       }
   }
}