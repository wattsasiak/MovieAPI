using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace MovieDataAPI.Models
{
    public class DAL
    {
        public static MySqlConnection DB;


        //get list of all movies
        public static List<Genre> GetAllGenres()
        {
            return DB.GetAll<Genre>().ToList();
        }

        public static Genre GetGenre(string id)
        {
            return DB.Get<Genre>(id);
        }


        public static GenreMovies GetAllForGenre(string thegenreId)
        {
            var keyvalues = new { _genreId = thegenreId };
            string sql = "select * from movie where genreId = @_genreId";  // Code in another language, stored in a string!
            GenreMovies GM = new GenreMovies();
            GM.my_movies = DB.Query<Movie>(sql, keyvalues).ToList();
            GM.my_genre = DAL.GetGenre(thegenreId);
            return GM;
        }

    }
}
