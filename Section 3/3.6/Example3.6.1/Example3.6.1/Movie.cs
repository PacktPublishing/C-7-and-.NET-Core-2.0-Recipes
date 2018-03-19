using System;
using System.Collections.Generic;
using System.Text;

namespace Example3._6._1
{
    public enum MovieGenre
    {
        Action,
        Comedy,
        Scifi,
        Horror
    }

    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public MovieGenre Genre { get; set; }


        public Movie(string title, int year, MovieGenre genre)
        {
            Title = title;
            Year = year;
            Genre = genre;
        }
    }
}
