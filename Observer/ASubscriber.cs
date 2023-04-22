using System.Threading;
namespace Observer
{
    public delegate bool SubEvent();
    public delegate void SubNotify();

    public abstract class ASubscriber
    {
        public string? Name { get; set; }
        public SubEvent? subEvent { get; set; }
        public SubNotify? subNotify { get; set; }

        public abstract void Notify();
        public void AsyncNotify()
        {
            Task.Run(() => Notify());
        }

    }
}