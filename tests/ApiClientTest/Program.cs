using IdentityModel.Client;


namespace ApiClientTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
            // 从元数据中发现端点
            var client = new HttpClient();
            var disco = await client.GetDiscoveryDocumentAsync("https://localhost:44310");
            if (disco.IsError)
            {
                Console.WriteLine(disco.Error);
                return;
            }
            else
            {
                Console.WriteLine(disco.Raw);
            }
            var tokenResponse = await client.RequestClientCredentialsTokenAsync(
                new ClientCredentialsTokenRequest
                {
                    Address = disco.TokenEndpoint,

                    ClientId = "skoruba_identity_admin",
                    ClientSecret = "secret",
                    Scope = "roles"
                });

            if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
                return;
            }

            Console.WriteLine(tokenResponse.Json);
            Console.ReadKey();
        }
    }
}
