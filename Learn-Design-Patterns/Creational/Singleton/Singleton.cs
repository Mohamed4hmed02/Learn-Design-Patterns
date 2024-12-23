namespace Learn_Design_Patterns.Creational.Singleton
{
    public class Singleton
    {
        private static readonly object _lock = new();
        private static Singleton? singleton;
        private Singleton()
        {

        }
        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    singleton ??= new Singleton();
                    return singleton;
                }
            }
        }
        public void DoSomeThing()
        {
            Console.WriteLine("This Is An Instance Of The Class");
        }
    }
}
