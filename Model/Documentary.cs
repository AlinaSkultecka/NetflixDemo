using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixDemo.Model
{
    class Documentary : MediaType
    {
        public string Topic { get; private set; } // Topic of the documentary
        public Documentary(string title, string genre, int releaseYear, string language, string topic) : base(title, genre, releaseYear, language)
        {
            Topic = topic;
        }

        public override void Play()
        {
            Console.WriteLine($"Playing documentary: {Title} - Topic: {Topic}");
        }
        public override string GetSummary()
        {
            return base.GetSummary() + $" - Topic: {Topic}";
        }   
    }
}
