using CURD_using_.Net_Web_API.Data;
using CURD_using_.Net_Web_API.DTOs;
using CURD_using_.Net_Web_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CURD_using_.Net_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly ApplicationDb _db;
        public GenreController(ApplicationDb db)
        {
            _db = db;
        }
        [HttpGet("GetAll")]
        public ActionResult GetAll() 
        {
            return Ok(_db.Genres.ToList()); 
        }
        [HttpGet("GetById/{id}")]
        public ActionResult GetById(int id)
        {
            var genre = _db.Genres.FirstOrDefault(x => x.Id == id);
            if(genre == null)
            {
                return BadRequest($"The Id : {id} is Not Exist");
            }
            var toReturn = new GenreDto
            {
                Id=genre.Id,
                Name=genre.Name
            };


            return Ok(toReturn);
        }
        [HttpPost("Create")]
        public ActionResult Create(GenreAddEditDto model)
        {
            if(GenreNameExist(model.Name))
            {
                return BadRequest("Genre Name Should Be Unique");
            }
            var genreToAdd = new Genre
            { Name=model.Name.ToLower()};
            _db.Genres.Add(genreToAdd);
            _db.SaveChanges();
            return Ok();

        }

        [HttpPut("update")]
        public IActionResult Update(GenreAddEditDto model)
        {
            var fetchedGenre = _db.Genres.Find(model.Id);
            if (fetchedGenre == null)
            {
                return NotFound();
            }

            if (GenreNameExist(model.Name))
            {
                return BadRequest("Genre name should be unique");
            }

            fetchedGenre.Name = model.Name.ToLower();
            _db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var fetchedObj = _db.Genres.Find(id);
            if (fetchedObj == null) return NotFound();

            _db.Genres.Remove(fetchedObj);
            _db.SaveChanges();

            return NoContent();
        }



    
        private bool GenreNameExist(string name) 
        {
            var fetchedGenre=_db.Genres.FirstOrDefault(x=>x.Name.ToLower()== name);
            if(fetchedGenre != null)
            {
                return true;
            }
            return false;
        }
    }
}
