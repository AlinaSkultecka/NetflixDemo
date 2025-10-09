using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixDemo.Model
{
    class KidsMovie : MediaType
    {
        public int RecommendedAge { get; private set; }
        public KidsMovie(string title, string genre, int releaseYear, string language, int recommendedAge) : base(title, genre, releaseYear, language)
        {
            RecommendedAge = recommendedAge;
        }

        public override void Play()
        {
            Console.WriteLine($"Playing movie: {Title}, recommended age is {RecommendedAge}");
        }
    }
}
