namespace Learn_Design_Patterns.Creational.Factory
{
    internal class PC(string ram, string cpu) : CopmuterAbstract(ram, cpu), IComputer
    {
        public void ShowCPU()
        {
            Console.WriteLine($"This is pc's CPU:{_cpu}");
        }

        public void ShowRAM()
        {
            Console.WriteLine($"This is pc's RAM:{_ram}");
        }
    }
}
