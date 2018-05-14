
using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        public static void Main(string[] args) => MainAsync().GetAwaiter().GetResult();

        private static async Task MainAsync()
        {
            // discover endpoints from metadata
            var disco = await DiscoveryClient.GetAsync("http://localhost:5000");

            if (disco.IsError)
            {
                Console.WriteLine(disco.Error);
                return;
            }

            //
            //var httpHandler = new HttpClientHandler();
            //httpHandler.CookieContainer.Add(new Uri("http://localhost:5000"), new Cookie(MultiTenancyConsts.TenantIdResolveKey, "1")); //Set TenantId
            //var tokenClient = new TokenClient(disco.TokenEndpoint, "client", "secret", httpHandler);
            //var tokenResponse = await tokenClient.RequestResourceOwnerPasswordAsync("admin", "123qwe");

            var tokenClient = new TokenClient
             (disco.TokenEndpoint, "debug_cosole", "AppliedTechnology");
            
            var tokenResponse = await tokenClient.RequestCustomGrantAsync("client_credentials");


            if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
                return;
            }

            Console.WriteLine(tokenResponse.Json);
            Console.WriteLine("\n\n");

            // call api
            var client = new HttpClient();
            client.SetBearerToken(tokenResponse.AccessToken);

            var response = await client.GetAsync("http://localhost:21021/api/services/app/user/GetAll");
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(JArray.Parse(content));
            }
        }
    }
}