using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;


namespace MovieDataAPI.Models
{

    [Table("genre")]
    public class Genre{

        [ExplicitKey]
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }


    }

    [Table("movie")]

        public class Movie{

        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public string year { get; set; }
        public string mainactor { get; set; }
        public string genreId { get; set; }
    }


    public class GenreMovies{

        public Genre my_genre { get; set; }
        public List<Movie> my_movies { get; set; }

    }


}
