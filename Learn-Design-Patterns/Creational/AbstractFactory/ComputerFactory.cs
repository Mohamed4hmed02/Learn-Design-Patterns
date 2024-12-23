using Learn_Design_Patterns.Creational.Factory;

namespace Learn_Design_Patterns.Creational.AbstractFactory
{
    internal static class ComputerFactory
    {
        public static IComputer GetComputer(ComputerAbstractFactory factory)
        {
            return factory.CreateComputer();
        }
    }
}
