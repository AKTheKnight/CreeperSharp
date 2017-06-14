namespace CreeperSharp.responses.server
{
    
    public class CPU : Response
    {
        public double Free { get; set; }
        public double Used { get; set; }
        public string Model { get; set; }
        public int Threads { get; set; }
        public string Frequency { get; set; }
    }
}
