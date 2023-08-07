using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;

namespace MsTests.Helpers
{
    public class Constants
    {
        public static string VALID_EMAIL = "asdf@asdf.com";
        public static string VALID_PASSWORD = "111111";
        public static string RANDOM_PASSWORD = StringFaker.Randomize(
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[{]};:'\",<.>/?");
    }
}
