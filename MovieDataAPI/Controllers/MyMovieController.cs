using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieDataAPI.Models;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;


namespace MovieDataAPI.Controllers
{
    [Route("api/genre")]
    [ApiController]
    public class MyMovieController : ControllerBase
    {
        [HttpGet]
        //https://localhost:44362/api/genre

        //get all genres at /api/genres
        public List<Genre> getAllGenres()
        {
            return DAL.GetAllGenres();
        }

        //https://localhost:44362/api/genre?genreId=DRMA

        [HttpGet("movies")]
        public List<Movie> getMoviesByGenre(string id)
        {
            return DAL.GetAllForGenre(id);

                        
        }


        //get all movies

        [HttpGet("movies/all")]
        //https://localhost:44362/api/genre/movies/all
        public List<Movie> getAllMovies()
        {
            return DAL.GetAllMovies();
        }

        [HttpPost]
        public string UpfateGenre (Genre my_genre)
        {
            DAL.UpdateGenre(my_genre);
            return my_genre.id;
        }

        [HttpDelete("{id}")]
        public bool deleteCategory(string id)
        {
            DAL.DeleteGenre(id);
            return true;
        }



    }
}
