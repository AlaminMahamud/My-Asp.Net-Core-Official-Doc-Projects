using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    static class SeedData
    {
        public static void Initialize(IServiceProvider service)
        {
                using(var context=new ApplicationDbContext(service.GetRequiredServices<DatabaseContextOptions<ApplicationDbContext>>())
                {
                    /// Look For Any Movies
                    if(context.Movie.Any)
                    {
                        return; // I am done with seeding
                    }

                    context.Movie.AddRange(
                        new Movie
                        {
                            Title = "When Harry Met Sally",
                            Genre = "abc",
                            ReleasedDate =DateTime.Parse("1987-1-11"),
                            Price=6.44m
                        },
                        new Movie
                        {
                            Title = "When Harry Met Sally",
                            Genre = "abc",
                            ReleasedDate =DateTime.Parse("1987-1-11"),
                            Price=6.44m
                        }
                    );

                    context.SaveChanges();
                }
        }
    }
}
