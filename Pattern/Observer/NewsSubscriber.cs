using System.Collections.Generic;

namespace DesignPatternsDemo.Observer
{
    /// <summary>
    /// Concrete subscriber that receives news updates.
    /// </summary>
    public class NewsSubscriber : ISubscriber
    {
        public string Name { get; }
        public List<string> ReceivedNews { get; } = new List<string>();
        public NewsSubscriber(string name)
        {
            Name = name;
        }
        public void Update(string news)
        {
            ReceivedNews.Add(news);
            Console.WriteLine($"[Observer] {Name} received news: {news}");
        }
    }
}
