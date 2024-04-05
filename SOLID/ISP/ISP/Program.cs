interface IWorker
{
    void Work();
}

interface IEater
{
    void Eat();
}

interface ISleeper
{
    void Sleep();
}

class BetterWorker : IWorker, IEater, ISleeper
{
    public void Work() { Console.WriteLine("Worker is working."); }
    public void Eat() { Console.WriteLine("Worker is eating."); }
    public void Sleep() { Console.WriteLine("Worker is sleeping."); }
}

class BetterRobot : IWorker
{
    public void Work() { Console.WriteLine("Robot is working."); }
}

class Program
{
    static void Main()
    {
        IWorker worker2 = new BetterWorker();
        IWorker robot2 = new BetterRobot();

        worker2.Work();
        robot2.Work();
    }
}
