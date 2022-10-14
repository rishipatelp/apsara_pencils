using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using apsara_pencils.Data;
using System;
using System.Linq;

namespace apsara_pencils.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new apsara_pencilsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<apsara_pencilsContext>>()))
            {
                //Look for the Pencil
                if(context.PencilClass.Any())
                {
                    return;
                }
                context.PencilClass.AddRange(
                    new PencilClass
                    {
                        productName = "Apsara 1",
                        Price = 1.99,
                        Color = "Black",
                        Category = "HB1",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Review = 2
                    },
                    new PencilClass
                    {
                        productName = "Apsara 2",
                        Price = 2.99,
                        Color = "White",
                        Category = "B1",
                        ReleaseDate = DateTime.Parse("1989-3-10"),
                        Review = 4
                    },
                    new PencilClass
                    {
                        productName = "Apsara 3",
                        Price = 3.99,
                        Color = "Dark Brown",
                        Category = "B2",
                        ReleaseDate = DateTime.Parse("1999-22-2"),
                        Review = 2
                    },
                    new PencilClass
                    {
                        productName = "Apsara 4",
                        Price = 3.79,
                        Color = "Pink",
                        Category = "B3",
                        ReleaseDate = DateTime.Parse("1999-3-2"),
                        Review = 3
                    },
                    new PencilClass
                    {
                        productName = "Apsara 5",
                        Price = 0.99,
                        Color = "Black",
                        Category = "HB1",
                        ReleaseDate = DateTime.Parse("2001-2-12"),
                        Review = 4
                    },
                    new PencilClass
                    {
                        productName = "Apsara 6",
                        Price = 3.99,
                        Color = "Purple",
                        Category = "B5",
                        ReleaseDate = DateTime.Parse("1959-8-2"),
                        Review = 1
                    },
                    new PencilClass
                    {
                        productName = "Apsara 7",
                        Price = 1.59,
                        Color = "Red",
                        Category = "HB3",
                        ReleaseDate = DateTime.Parse("1977-4-12"),
                        Review = 5
                    },
                    new PencilClass
                    {
                        productName = "Apsara 8",
                        Price = 1.99,
                        Color = "Blue",
                        Category = "HB4",
                        ReleaseDate = DateTime.Parse("1999-12-12"),
                        Review = 4
                    },
                    new PencilClass
                    {
                        productName = "Apsara 9",
                        Price = 1.89,
                        Color = "Cyan",
                        Category = "HB5",
                        ReleaseDate = DateTime.Parse("1999-12-3"),
                        Review = 4
                    },
                    new PencilClass
                    {
                        productName = "Apsara 10",
                        Price = 0.99,
                        Color = "Black",
                        Category = "HB2",
                        ReleaseDate = DateTime.Parse("2000-2-12"),
                        Review = 5
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
