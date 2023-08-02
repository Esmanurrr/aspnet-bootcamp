using CodeFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private BtkAkademiDbContext _dbContext;//veritabanına bağlantı sağlar

        public MoviesController(BtkAkademiDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }

        [HttpGet]
        public List<Movie> FilmleriGetir()
        {
            List<Movie> movies = new List<Movie>();
            movies = _dbContext.Movie.ToList(); //select*from Movie
            return movies;
        }

        //dışarıdan post tipinde bir json objesi göndereceğiz.
        [HttpPost]
        public Movie FilmEkle(Movie movie)
        {
            _dbContext.Movie.Add(movie); //adonet kullanarak insert into
            _dbContext.SaveChanges(); //execute nonquery metodunu çağıracak
            return movie;
        }

        [HttpPut]
        public Movie FilmGuncelle(Movie movie)
        {
            _dbContext.Movie.Update(movie); //adonet kullanarak update sorgusu çalışacak 
            _dbContext.SaveChanges(); //execute nonquery metodunu çağıracak
            return movie;
        }

        [HttpDelete("{id}")]
        public void FilmSil(int id)
        {
            Movie silinecekFilm = _dbContext.Movie.Find(id); //select*from Movie where Id = 1
            _dbContext.Movie.Remove(silinecekFilm);
            _dbContext.SaveChanges();
        }

        [HttpGet("{id}")]
        public Movie FilmDetayGetir(int id)
        {
            Movie detayMovie = _dbContext.Movie.Find(id); //select*from Movie where Id = 1
            return detayMovie;
        }
    }
}
