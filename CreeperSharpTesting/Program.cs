using System.Diagnostics;
using CreeperSharp;

namespace CreeperSharpTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var credentials = new ConnectionCredentials(
                key: "s59303b72a4f85@AKTheNite.playat.ch", 
                secret: "19f27de6732afa69a6afebb3776add9957024628a5390ff046132c5dfcd6b236843bb55484ab6244176d7408a643cfc68948b2d1960499b8ef02beaaf6999160");

            var client = new CreeperClient { Credentials = credentials };

            var cpu = client.GetCPU();
            var hdd = client.GetHDD();
            var ram = client.GetRAM();
            var net = client.GetNet();

            Debug.Write("SDAKh");
        }
    }
}
