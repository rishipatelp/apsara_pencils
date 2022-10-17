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
                        productName = "Apsara A",
                        Price = 2,
                        Color = "Black",
                        Category = "A",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Review = 2
                    },
                    new PencilClass
                    {
                        productName = "Apsara B",
                        Price = 2,
                        Color = "White",
                        Category = "B",
                        ReleaseDate = DateTime.Parse("1989-3-10"),
                        Review = 4
                    },
                    new PencilClass
                    {
                        productName = "Apsara C",
                        Price = 3,
                        Color = "Dark Brown",
                        Category = "C",
                        ReleaseDate = DateTime.Parse("1999-2-2"),
                        Review = 2
                    },
                    new PencilClass
                    {
                        productName = "Apsara D",
                        Price = 3,
                        Color = "Pink",
                        Category = "D",
                        ReleaseDate = DateTime.Parse("1999-3-2"),
                        Review = 3
                    },
                    new PencilClass
                    {
                        productName = "Apsara E",
                        Price = 1,
                        Color = "Black",
                        Category = "E",
                        ReleaseDate = DateTime.Parse("2001-2-12"),
                        Review = 4
                    },
                    new PencilClass
                    {
                        productName = "Apsara F",
                        Price = 5,
                        Color = "Purple",
                        Category = "F",
                        ReleaseDate = DateTime.Parse("1959-8-2"),
                        Review = 1
                    },
                    new PencilClass
                    {
                        productName = "Apsara G",
                        Price = 2,
                        Color = "Red",
                        Category = "G",
                        ReleaseDate = DateTime.Parse("1977-4-12"),
                        Review = 5
                    },
                    new PencilClass
                    {
                        productName = "Apsara H",
                        Price = 1,
                        Color = "Blue",
                        Category = "H",
                        ReleaseDate = DateTime.Parse("1999-1-12"),
                        Review = 4
                    },
                    new PencilClass
                    {
                        productName = "Apsara I",
                        Price = 1,
                        Color = "Cyan",
                        Category = "I",
                        ReleaseDate = DateTime.Parse("1999-1-3"),
                        Review = 4
                    },
                    new PencilClass
                    {
                        productName = "Apsara J",
                        Price = 2,
                        Color = "Black",
                        Category = "J",
                        ReleaseDate = DateTime.Parse("2000-2-12"),
                        Review = 5
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
