namespace Learn_Design_Patterns.Creational.Factory
{
    internal class Server(string ram, string cpu) : CopmuterAbstract(ram, cpu), IComputer
    {
        public void ShowCPU()
        {
            Console.WriteLine($"This is server's CPU:{_cpu}");
        }

        public void ShowRAM()
        {
            Console.WriteLine($"This is server's RAM:{_ram}");
        }
    }
}
