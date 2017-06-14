using CreeperSharp;
using CreeperSharp.responses.server;

namespace CreeperSharpTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            CreeperClient client;
            ConnectionCredentials credentials = new ConnectionCredentials("api_ key", "api_secret");

            client = new CreeperClient(credentials);

            CPU cpu = client.GetCPU();

            string model = cpu.Model;






            /*string key = Environment.GetEnvironmentVariable("key");
            string secret = Environment.GetEnvironmentVariable("secret");


            var credentials = new ConnectionCredentials(key, secret);

            var client = new CreeperClient { Credentials = credentials };

            var cpu = client.GetCPU();
            var hdd = client.GetHDD();
            var ram = client.GetRAM();
            var net = client.GetNet();*/
        }
    }
}
