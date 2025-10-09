using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NetflixDemo.Model
{
    static class MediaPlayer
    {
        private static List<MediaType> mediaLibrary = new List<MediaType>()
        {
            new Movie("Inception", "Sci-Fi", 2010, "English", 148),
            new Series("Stranger Things", "Sci-Fi", 2016,"English", 4),
            new Documentary("Planet Earth", "Nature", 2006, "English","Wildlife"),
            new Movie("The Dark Knight", "Action", 2008, "English",152),
            new Series("Breaking Bad", "Crime", 2008, "English", 5),
            new Documentary("The Last Dance", "Sports", 2020, "English", "Michael Jordan"),
        };
        public static void Run()
        {
            bool running = true;

            while (running)
            {
                PrintMenu();
                switch (Console.ReadLine())
                {
                    case "1":
                        ViewMediaLibrary();
                        break;
                    case "2":
                        FilterByGenre();
                        break;
                    case "3":
                        SearchByTitle();
                        break;
                    case "4":
                        PlayMedia();
                        break;
                    case "5":
                        ShowOnlyDocumentary();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Netflix MINI ===");
            Console.WriteLine("1. View Media Library");
            Console.WriteLine("2. Filter by Genre");
            Console.WriteLine("3. Search by Title");
            Console.WriteLine("4. Play Media");
            Console.WriteLine("5. Show only Documentary");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");
        }

        private static void ViewMediaLibrary()
        {
            Console.Clear();
            Console.WriteLine("=== Media Library ===");
            foreach (var media in mediaLibrary)
            {
                Console.WriteLine(media.GetSummary());
            }
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }

        private static void FilterByGenre()
        {
            Console.Clear();
            Console.WriteLine("Enter genre to filter: ");
            string genre = Console.ReadLine().ToLower();

            bool found = false;
            foreach (var media in mediaLibrary)
            {
                if (media.Genre.ToLower() == genre)
                {
                    Console.WriteLine(media.GetSummary());
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No media found in that genre.");
            }
            
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
        
        private static void SearchByTitle()
        {
            Console.Clear();
            Console.Write("Enter title to search: ");
            string title = Console.ReadLine().ToLower();

            bool found = false;
            foreach (var media in mediaLibrary)
            {
                if (media.Title.ToLower() == title)
                {
                    Console.WriteLine(media.GetSummary());
                    found = true;
                    break;
                }  
            }
            if (!found)
            {
                Console.WriteLine("No media found in that genre.");
            }
            
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }

        private static void PlayMedia()
        {
            Console.WriteLine("Enter title to play: ");
            string title = Console.ReadLine().ToLower();
            
            bool found = false;
            foreach (var media in mediaLibrary)
            {
                if (media.Title.ToLower() == title)
                {
                    media.Play();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("No media found with that title.");
            }
        }

        public static void GetUppercaseTitle()
        {
            Console.Clear();
            Console.WriteLine("=== TITLES IN UPPERCASE ===");

            foreach (var media in mediaLibrary)
            {
                Console.WriteLine(media.Title.ToUpper());
            }

            Console.WriteLine("\nPress Enter to return to the menu.");
            Console.ReadLine();
        }

        public static void GetAge()
        {
            int currentYear = DateTime.Now.Year;
            foreach (var media in mediaLibrary)
            {
                int age = currentYear - media.ReleaseYear;
                Console.WriteLine($"{media.Title} is {age} years old.");
            }
            Console.WriteLine("\nPress Enter to return to the menu.");
            Console.ReadLine();
        }

        public static void ViewMovies()
        {
            Console.Clear();
            Console.WriteLine("=== MOVIES ===");

            foreach (var media in mediaLibrary)
            {
                if (media is Movie) // check if the item is a Movie
                {
                    Console.WriteLine(media.GetSummary());
                }
            }
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }

        public static void ViewSeries()
        {
            Console.Clear();
            Console.WriteLine("=== SERIES ===");

            foreach (var media in mediaLibrary)
            {
                if (media is Series) // check if the item is a Movie
                {
                    Console.WriteLine(media.GetSummary());
                }
            }
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }

        public static void ShowLongMovies()
        {
            Console.Clear();
            Console.WriteLine("=== MOVIES LONGER THAN 2 HOURS ===");
            foreach (var media in mediaLibrary)
            {
                if (media is Movie movie && movie.DurationMinutes > 120) // check if the item is a Movie
                {
                    Console.WriteLine(media.GetSummary());
                }
            }
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
        
        public static void ShowSeriesWithManySeasons()
        {
            Console.Clear();
            Console.WriteLine("=== SERIES WITH MORE THAN 3 SEASONS ===");
            foreach (var media in mediaLibrary)
            {
                if (media is Series series && series.Seasons > 3) // check if the item is a series
                {
                    Console.WriteLine(media.GetSummary());
                }
            }
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }

        private static void ShowOnlyDocumentary()
        {
            Console.Clear();
            Console.WriteLine("=== DOCUMENTARY ===");
            foreach (var media in mediaLibrary)
            {
                if (media is Documentary)
                {
                    Console.WriteLine(media.GetSummary());
                }
            }
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}
