using Microsoft.Extensions.Configuration;
using System.IO;

namespace arivanitask.PageObjects
{
    public static class Configuration
    {
        private static IConfigurationRoot ConfigurationRoot = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("PageModel.json", optional: false, reloadOnChange: false)
            .Build();

        public static string BaseUrl => ConfigurationRoot["AppSettings:BaseUrl"];
        public static string Name => ConfigurationRoot["Data:Name"];
        public static string Email => ConfigurationRoot["Data:Email"];
        public static string password => ConfigurationRoot["Data:password"];
        public static string Dob => ConfigurationRoot["Data:Dob"];
        public static string pic => ConfigurationRoot["Data:pic"];
        public static string address=> ConfigurationRoot["Data:address"];
        public static string city => ConfigurationRoot["Data:city"];
        public static string ucity => ConfigurationRoot["Data:ucity"];
        public static string upassword => ConfigurationRoot["Data:upassword"];
        public static string upic => ConfigurationRoot["Data:upic"];
    }
}
