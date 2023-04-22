
namespace Observer
{
    public abstract class AObserver
    {
        public bool isObserving { get; set; }
        public Task? Observe { get; set; }
        public abstract void StartObserve();
        public List<ASubscriber>? SubScribers { get; set; }

        public abstract void AddSubscriber(ASubscriber? subscriber);
        public void AsyncStartObserve()
        {
            Observe = Task.Run(() => StartObserve());
        }
    }
}