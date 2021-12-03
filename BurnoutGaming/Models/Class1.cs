using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BurnoutGaming.Data;
using System;
using System.Linq;

namespace BurnoutGaming.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BurnoutGamingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BurnoutGamingContext>>()))
            {
                // Look for any movies.
                if (context.Members.Any())
                {
                    return;   // DB has been seeded
                }

                context.Members.AddRange(
                    new Members
                    {
                        MemberInfo = "5under5truck",
                        Name = "Adam",
                        email = "a_sunder_91@hotmail.com",
                    },

                    new Members
                    {
                        MemberInfo = "Reverand",
                        Name = "Jeff",
                        email = "reverand@hotmail.com",
                    },

                    new Members
                    {
                        MemberInfo = "MericanVenom",
                        Name = "Jaden",
                        email = "MericanVenom@hotmail.com",
                    },

                    new Members
                    {
                        MemberInfo = "JoeMadBro",
                        Name = "Joe",
                        email = "JoeMadBro@hotmail.com",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}