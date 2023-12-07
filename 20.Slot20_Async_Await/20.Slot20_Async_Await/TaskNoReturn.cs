

class TaskNoReturn
{
    static void DoSomething(int time, string message, ConsoleColor color)
    {
        lock (Console.Out)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{message}...start");
            Console.ResetColor();
        }
        for (int i = 0; i < time; i++)
        {
            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(message);
                Console.ResetColor();
                Thread.Sleep(1000);
            }
        }
        lock (Console.Out)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{message}...end");
            Console.ResetColor();
        }
    }

    static async Task Task2()
    {
        Task t2 = new Task(
            () =>
            {
                DoSomething(7, "T2", ConsoleColor.Red);
            }
            );
        t2.Start();
        await t2; // t2.Wait() will lock thread t2. We must you async, await to make it async
        Console.WriteLine("Task2 completed");
    }
    static async Task Task3()
    {
        Task t3 = new Task(
            (Object obj) =>
            {
                DoSomething(4, obj + "", ConsoleColor.Magenta);
            }, "T3"
            );
        t3.Start();
        await t3; // t3.Wait() will lock thread t3. We must you async, await to make it async
        Console.WriteLine("Task3 completed");
    }

    public static void Main(string[] args)
    {
        Task t2 = Task2(); // First thread
        Task t3 = Task3(); // Second thread
        DoSomething(2, "T1", ConsoleColor.Green); // Third thread

        // Ensure task completed before run the next command
        //t2.Wait();
        //t3.Wait();
        // Or 
        // Task.WaitAll(t2,t3);

        Console.WriteLine("Hello World!");
        Console.ReadLine();
    }
}

