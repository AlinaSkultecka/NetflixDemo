using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixDemo.Model
{
    class Series : MediaType
    {
        public int Seasons { get; private set; } // Number of seasons
        public Series(string title, string genre, int releaseYear, string language, int seasons) : base(title, genre, releaseYear, language)
        {
            Seasons = seasons;
        }

        public override void Play()
        {
            Console.WriteLine($"Playing series: {Title} - {Seasons} seasons available");
        }
    }
}
