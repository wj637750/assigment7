using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using assigment7.Data;

namespace assigment7.Models
{
    public class SeedData{

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Football",
                        Description = "A ball for football",
                        Categroy = "balls",
                        Price = 10
                    },
                    new Product
                    {
                        Name = "Soccer ball",
                        Description = "A ball for soccer",
                        Categroy = "balls",
                        Price = 10
                    },
                    new Product
                    {
                        Name = "Video Game",
                        Description = "A game for a video game console",
                        Categroy = "Video games",
                        Price = 60
                    },
                    new Product
                    {
                        Name = "video game console",
                        Description = "a console used to play video games",
                        Categroy = "Video games",
                        Price = 300
                    },
                    new Product
                    {
                        Name = "cards",
                        Description = "A pack of playing cards",
                        Categroy = "misc",
                        Price = 3
                    },
                    new Product
                    {
                        Name = "bowling pins",
                        Description = "Pins for bowling",
                        Categroy = "misc",
                        Price = 50
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
