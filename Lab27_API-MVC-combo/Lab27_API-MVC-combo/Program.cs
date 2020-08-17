using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

/// <summary>
/// Day 53 (Work with JSON from weather API)
/// Exercise: Lets take our program from the other day that utilized the Weather API. 
/// We will now pull out more data from the API, and display it. Experiment with 
/// different ways to display the data. You can use tables, but you can also mess with
/// div’s, and don’t forget about BootStrap classes!
/// 
/// FOUND OUT: Current Observation is all we care about
/// </summary>


namespace Lab27_API_MVC_combo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
