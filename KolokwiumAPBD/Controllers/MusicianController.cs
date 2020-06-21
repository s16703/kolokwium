using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KolokwiumAPBD.Models;
using KolokwiumAPBD.DTOs.Responses;
using KolokwiumAPBD.DTOs.Requests;

namespace KolokwiumAPBD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicianController : ControllerBase
    {
        private readonly MisicianDbContext _context;
        public MusicianController(MisicianDbContext context)
        {
            _context = context;
        }

        [Route("api/musicians/{id}")]
        [HttpGet]
        public IActionResult GetMusicianInfo(int IdMusician)
        {
            ICollection<Musician_Track> tracks;
            if (IdMusician == null)
            {
                return BadRequest("Brak takiego ID w bazie");
            }
            else
            {
                tracks = _context.Musitian_Tracks
                    .Where(z => z.Musician.IdMusician == IdMusician)
                    .ToList();
                return Ok(tracks);
            }
        }
      
      /*  
        [HttpPost]
        public IActionResult CreateOrder(CreateMusicianDtoRequest request)
        {

            var music = await _dbService.GetMusician(input.IdMusician);
            var track = await _dbService.GetTrack(input.IdTrack);
            if (track == null)
            {
                return BadRequest();
            }
            else
            {
                await _dbService.AddMusician(input.FirstName,input.LastName, input.NickName);
                return StatusCode(201);
            }
        }
      */
    }
}
