using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project_underscore_api.Data;
using project_underscore_api.Models;

namespace project_underscore_api.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProjectUnderscoreContext context)
        {
            //context.Database.EnsureCreated();

            //Look for data
            if(context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User{DisplayName="Jordan",Email="jordan@jordan.com",Password="pewpew"},
                new User{DisplayName="TJ",Email="tj@jordan.com",Password="iAmAnOoB"}
            };

            context.Users.AddRange(users);
            context.SaveChanges();

            users[1].Items.AddRange(new UserItem[] {
                new UserItem { Name = "Folgers", Description = "medium roast coffee", Opinion = "not a fan", Rating = 1 },
                new UserItem { Name = "Donut Shop", Description = "medium roast coffee", Opinion = "awesome", Rating = 9 }
            });

            context.SaveChanges();
            //var items = new Item[]
            //{
            //    new Item{Name="Folgers",Description="medium roast coffee",Opinion="not a fan",Rating=1},
            //    new Item{Name="Donut Shop",Description="medium roast coffee",Opinion="awesome",Rating=9}
            //};

            //context.Items.AddRange(items);
            //context.SaveChanges();
        }
    }
}
