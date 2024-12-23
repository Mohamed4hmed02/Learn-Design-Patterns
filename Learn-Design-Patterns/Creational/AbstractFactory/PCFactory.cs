using Learn_Design_Patterns.Creational.Factory;

namespace Learn_Design_Patterns.Creational.AbstractFactory
{
    internal class PCFactory(string ram, string cpu) : ComputerAbstractFactory
    {
        public override IComputer CreateComputer()
        {
            return new PC(ram, cpu);
        }
    }
}
