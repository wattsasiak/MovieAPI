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


        //get list of all genres
        public static List<Genre> GetAllGenres()
        {
            return DB.GetAll<Genre>().ToList();
        }



        public static Genre GetGenre(string id)
        {
            return DB.Get<Genre>(id);
        }


        //get all movies by specific genre

        public static List<Movie> GetAllForGenre(string thegenreId)
        {
            var keyvalues = new {genreId = thegenreId };
            string sql = "select * from movie where genreId = @genreId"; 
            return DB.Query<Movie>(sql, keyvalues).ToList();


        }


        //get all movies
        public static List<Movie> GetAllMovies()
        {
            return DB.GetAll<Movie>().ToList();
        }

     
        //update
        public static void UpdateGenre(Genre my_genre)
        {
            Genre updategenre = DAL.GetGenre(my_genre.id);
            DB.Update(my_genre);
        }

        //delete
        public static void DeleteGenre(string thegenreId)
        {
            Genre my_genre = new Genre() { id = thegenreId };
            DB.Delete(my_genre);
        }



    }
}
