using Observer;

namespace Proj
{
    public class Program
    {
        public static int a, b;
        public static void Main() 
        {
            Observer3 observer = new Observer3();
            var sub = new Subscriber(CheckEvent, Notify);
            observer.AddSubscriber(sub);
            observer.AsyncStartObserve();
            while (a+b != 555)
            {
                try 
                {
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                }
                catch 
                { 
                }
            }
            observer.isObserving = false;
            GC.Collect();
        }


        public static bool CheckEvent()
        {
            return (a + b < 0);
        }
        public static void Notify()
        {
            Console.WriteLine("Произошло событие!");
        }
    }
}