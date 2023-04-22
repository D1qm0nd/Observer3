using Observer;

namespace Proj
{
    public class Program
    {
        public static int a, b;
        public static void Main() 
        {
            Observer3 observer = new Observer3();
            observer.AddSubscriber(new Subscriber(CheckEvent1, Notify1));
            observer.AddSubscriber(new Subscriber(CheckEvent2, Notify2));
            observer.AddSubscriber(new Subscriber(CheckEvent3, Notify3));

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
            Console.WriteLine("Было введено 555, программа завершилась успешно!");
        }



        public static bool CheckEvent1()
        {
            return (a + b < 0);
        }

        public static bool CheckEvent2()
        {
            return ((a + b > 0) && (a + b < 100));
        }

        public static bool CheckEvent3()
        {
            return (a + b >= 100);
        }

        public static void Notify1()
        {
            Console.WriteLine("Событие sum < 0");
        }

        public static void Notify2()
        {
            Console.WriteLine("Событие 0 > sum < 100");
        }

        public static void Notify3()
        {
            Console.WriteLine("Событие sum >= 100");
        }

    }
}