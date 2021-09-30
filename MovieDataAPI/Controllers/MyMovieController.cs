using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieDataAPI.Models;

namespace MovieDataAPI.Controllers
{
    [Route("api/genres")]
    [ApiController]
    public class MyMovieController : ControllerBase
    {
        [HttpGet]

        //get all movies at /api/genres
        public List<Genre> getAllGenres()
        {
            return DAL.GetAllGenres();
        }


        //[HttpGet("movies")]
        //public List<Movie> getMoviesByGenre(string id)
        //{
        //    return DAL.GetAllForGenre(id);
        //}







    }
}
