using Learn_Design_Patterns.Creational.Factory;

namespace Learn_Design_Patterns.Creational.AbstractFactory
{
	internal class ServerFactory(string ram, string cpu) : ComputerAbstractFactory
	{
		public override IComputer CreateComputer()
		{
			return new Server(ram, cpu);
		}
	}
}
