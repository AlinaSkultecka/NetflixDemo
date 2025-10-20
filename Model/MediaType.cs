using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixDemo.Model
{
    enum GenreType
    {
        Drama,
        Science,
        SciFi,
        Nature,
        Action,
        Crime,
        Sports,
        Documentary,
        Horror,
        Comedy,
        Romance
    }


    abstract class MediaType
    {
        public string Title { get; private set; }
        public GenreType Genre { get; private set; }
        public int ReleaseYear { get; private set; }
        public string Language { get; set; } = "English"; // Default language

        public MediaType(string title, GenreType genre, int releaseYear, string language)
        {
            Title = title;
            Genre = genre;
            ReleaseYear = releaseYear;
            Language = language;
        }

        // Abstract method to be implemented by derived classes, nust be overrided
        public abstract void Play();

        public virtual string GetSummary()
        {
            return $"{Title} ({ReleaseYear}) - Genre: {Genre}, Language: {Language}";
        }
    }
}
