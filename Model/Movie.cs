using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixDemo.Model
{
    class Movie : MediaType
    {
        public int DurationMinutes { get; private set; } // Duration in minutes

        public Movie(string title, GenreType genre, int releaseYear, string language, int durationMinutes) : base(title, genre, releaseYear, language)
        {
            DurationMinutes = durationMinutes;
        }

        public override void Play()
        {
            Console.WriteLine($"Playing movie: {Title} ({DurationMinutes} min)");
        }

        public override string GetSummary()
        {
            return base.GetSummary() + $", Duration: {DurationMinutes} min";
        }

        public bool IsClassic()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - ReleaseYear > 20;
        }
    }
}
