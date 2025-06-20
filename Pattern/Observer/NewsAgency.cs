using System.Collections.Generic;

namespace DesignPatternsDemo.Observer
{
    /// <summary>
    /// News agency (subject) that notifies subscribers.
    /// </summary>
    public class NewsAgency
    {
        private readonly List<ISubscriber> _subscribers = new();
        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }
        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }
        public void PublishNews(string news)
        {
            foreach (var sub in _subscribers)
            {
                sub.Update(news);
            }
        }
    }
}
