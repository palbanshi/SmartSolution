using Smartsolutions.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartsolutions.Infrastructure.Persistence
{
    internal class SmartsolutionsSeeders(SmartsolutionsDbContext dbContext) : ISmartsolutionsSeeders
    {
        public async Task Seed()
        {
            if (await dbContext.Database.CanConnectAsync())
            {
                if (!dbContext.users.Any())
                {
                    var users = GetUsers();
                    dbContext.users.AddRange(users);
                    await dbContext.SaveChangesAsync();
                }
            }
        }
        private IEnumerable<User> GetUsers()
        {
            List<User> users = [
                new()
                {
                    Id = 1,
                    Name = "Banshi Pal",
                    Email="palbanshi@gmail.com",
                    password="admin@123",
                    address= new() {
                        Country="India",
                        City="Bangalore",
                        Street="2n cross",
                        PostalCode="560067"
                    }
                },
             new()
                {
                    Id = 2,
                    Name = "Rahul Pal",
                    Email="palrahul@gmail.com",
                    password="admin@123",
                    address= new() {
                        Country="India",
                        City="Hyderabad ",
                        Street="3rd cross",
                        PostalCode="510067"
                    }
                },
             new()
                {
                    Id = 3,
                    Name = "Pintu",
                    Email="pintu@gmail.com",
                    password="admin@123",
                    address= new() {
                        Country="India",
                        City="Bangalore",
                        Street="2nd cross",
                        PostalCode="560067"
                    }
                },
             new()
                {
                    Id = 4,
                    Name = "Sumit Kumar",
                    Email="sumit@gmail.com",
                    password="admin@123",
                    address= new() {
                        Country="India",
                        City="Bangalore",
                        Street="2nd cross",
                        PostalCode="560067"
                    }
                },
             new()
                {
                    Id = 5,
                    Name = "Ram Pal",
                    Email="palram@gmail.com",
                    password="admin@123",
                    address= new() {
                        Country="India",
                        City="Basti",
                        Street="2nd cross",
                        PostalCode="272151"
                    }
                },
              new()
                {
                    Id = 6,
                    Name = "Suresh Pal",
                    Email="palsuresh@gmail.com",
                    password="admin@123",
                    address= new() {
                        Country="India",
                        City="Bangalore",
                        Street="2nd cross",
                        PostalCode="560067"
                    }
                },
             new()
                {
                    Id = 7,
                    Name = "Manish Kumar",
                    Email="palmanishkumar@gmail.com",
                    password="admin@123",
                    address= new() {
                        Country="India",
                        City="Bangalore",
                        Street="2ncross",
                        PostalCode="560067"
                    }
                }];

            return users;
        }
    }
}
