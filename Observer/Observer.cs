namespace Observer
{
    public class Observer3 : AObserver
    {
        public Observer3()
        {
            SubScribers = new List<ASubscriber>();
        }
        public override void StartObserve()
        {
            isObserving = true;
            while (isObserving) 
            {
                foreach (var sub in SubScribers!)
                {
                    if (sub.subEvent.Invoke() == true)
                    {
                        sub.Notify();
                    }
                }
                Thread.Sleep(1000);
            }
        }

        public override void AddSubscriber(ASubscriber? subscriber)
        {
            if (subscriber != null)
                SubScribers!.Add(subscriber!);
            else throw new ArgumentException("Вы не передали подписчика");
        }


    }
}