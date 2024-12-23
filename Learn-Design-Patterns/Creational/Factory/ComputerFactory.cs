namespace Learn_Design_Patterns.Creational.Factory
{
	public static class ComputerFactory
    {
        public static IComputer GetComputer(ComputerType type, string cpu, string ram)
        {
            if (type == ComputerType.PC)
                return new PC(ram, cpu);
            else if (type == ComputerType.Server)
                return new Server(ram, cpu);
            throw new ArgumentException();
        }
    }
}
