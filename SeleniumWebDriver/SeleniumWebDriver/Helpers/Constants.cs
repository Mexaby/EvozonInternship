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
        public const string VALID_FULL_NAME = "Andrew 123 Tate";

        public const string LOGIN_HELLO_MESSAGE = "Hello, Andrew 123 Tate!";
        public const string HEADER_LOGGED_IN_MESSAGE = "WELCOME, ANDREW 123 TATE!";
        public const string HEADER_LOGGED_OUT_MESSAGE = "WELCOME";
        public const string LOGOUT_MESSAGE = "YOU ARE NOW LOGGED OUT";

        public static string RANDOM_EMAIL = Internet.Email();
        public static string RANDOM_PASSWORD = StringFaker.Randomize(
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[{]};:'\",<.>/?");

        public static string ADMIN_USERNAME = "testuser";
        public static string ADMIN_PASSWORD = "password123";

        public static string CONFIGURABLE_PRODUCT = "Chelsea Tee";
        public static string DIGITAL_PRODUCT = "A Tale of Two Cities";
        public static string SIMPLE_PRODUCT = "Broad St. Flapover Briefcase";
    }
}
