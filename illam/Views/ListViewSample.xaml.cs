using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace illam.Views
{
    public partial class ListViewSample : ContentPage
    {
        public List<Movie> MovieList
        {
            get;
            set;
        }
     
        public ListViewSample()
        {
            InitializeComponent();
            Init();

            this.BindingContext = this;
        }

        private void Init()
        {
            MovieList = new List<Movie>() { 
                new Movie { MovieName = "Movie1", MovieDesc = "movie1 desc", MovieRating="1"},
                new Movie { MovieName = "Movie2", MovieDesc = "movie2 desc", MovieRating="2"},
                new Movie { MovieName = "Movie3", MovieDesc = "movie3 desc", MovieRating="3"},
                new Movie { MovieName = "Movie4", MovieDesc = "movie4 desc", MovieRating="4"},
                new Movie { MovieName = "Movie5", MovieDesc = "movie5 desc", MovieRating="1"},
                new Movie { MovieName = "Movie6", MovieDesc = "movie6 desc", MovieRating="9"},
                new Movie { MovieName = "Movie7", MovieDesc = "movie7 desc", MovieRating="10"}
            };
        }



    }

    public class Movie
    {
        public string MovieName
        {
            get;
            set;
        }

        public string MovieDesc
        {
            get;
            set;
        }

        public string MovieRating
        {
            get;
            set;
        }
    }
}
