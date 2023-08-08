using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTests.Helpers
{
    public class NewAccount
    {
        public string FirstName { get; set; } = Faker.Name.First();
        public string MiddleName { get; set; } = Faker.Name.Middle();
        public string LastName { get; set; } = Faker.Name.Last();
        public string Email { get; set; } = Faker.Internet.Email();
        public string Password { get; set; } = Constants.RANDOM_PASSWORD;
    }
}
