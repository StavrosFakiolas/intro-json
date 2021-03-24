using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToJsonFull.App
{
    class Program
    {
        // step one - using the nuget package manager
        // https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string json = @"{""key1"":""value1"",""key2"":""value2""}";

            IDictionary<string, string> values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            foreach (string k in values.Keys)
                Console.WriteLine($"{k}: {values[k]}");


            // e.g. https://www.newtonsoft.com/json/help/html/DeserializeObject.htm 
            string json2 = @"{
            'Email': 'james@example.com',
            'Active': true,
            'CreatedDate': '2021-01-20T00:00:00Z',
            'Roles': [
                'User',
                'Admin'
            ]
            }";



            Account account = JsonConvert.DeserializeObject<Account>(json2);


            Console.WriteLine(account.Email);

            Account a2 = new Account("a@b.com", false, DateTime.UtcNow, new List<string>{"User"});
            string j3 = JsonConvert.SerializeObject(a2);
            Console.WriteLine(j3);


            string jsonDownload;
            using(var wc = new WebClient())
            {
                jsonDownload = wc.DownloadString("http://api.worldbank.org/v2/countries/USA/indicators/NY.GDP.MKTP.CD?per_page=5000&format=json");
           
            }

            dynamic j = JArray.Parse(jsonDownload);

            dynamic l = j[1];
            Console.WriteLine(l.Count);
            foreach(dynamic row in l)
            {
                Console.WriteLine($"{row.date}: {row.countryiso3code}: ${row.value / 1000000000:F3}bn");
            }

            Console.ReadKey();


        }

        public class Account
        {
            string _email;
            bool _active;
            DateTime _created;
            IList<string> _roles;

            public string Email { get => _email; set => _email = value; }
            public bool Active { get => _active; set => _active = value; }
            public DateTime CreatedDate { get => _created; set => _created = value; }
            public IList<string> Roles { get => _roles; set => _roles = value; }

            public Account(string e, bool a, DateTime c, IList<string> r)
            {
                _email = e;
                _active = a;
                _created = c;
                _roles = r;
            }
        }
    }
}
