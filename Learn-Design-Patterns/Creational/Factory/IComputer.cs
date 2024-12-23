namespace Learn_Design_Patterns.Creational.Factory
{
    public interface IComputer
    {
        void ShowRAM();
        void ShowCPU();
    }

    public abstract class CopmuterAbstract(string ram, string cpu)
    {
        protected readonly string _ram = ram;
        protected readonly string _cpu = cpu;
    }

    public enum ComputerType
    {
        PC,
        Server
    }
}
