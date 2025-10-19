using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VideoGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        static private List<VideoGame> videoGames = new List<VideoGame>
        {
            new VideoGame
            {
                Id = 1,
                Title = "The Legend of Zelda: Breath of the Wild",
                Plataform = "Nintendo Switch",
                Developer = "Nintendo EPD",
                Publisher = "Nintendo"
            },
            new VideoGame
            {
                Id = 2,
                Title = "God of War: Ragnarök",
                Plataform = "PlayStation 5",
                Developer = "Santa Monica Studio",
                Publisher = "Sony Interactive Entertainment"
            },
            new VideoGame
            {
                Id = 3,
                Title = "Elden Ring",
                Plataform = "PC",
                Developer = "FromSoftware",
                Publisher = "Bandai Namco Entertainment"
            },
            new VideoGame
            {
                Id = 4,
                Title = "Red Dead Redemption 2",
                Plataform = "Xbox One",
                Developer = "Rockstar Games",
                Publisher = "Rockstar Games"
            },
            new VideoGame
            {
                Id = 5,
                Title = "Super Mario Odyssey",
                Plataform = "Nintendo Switch",
                Developer = "Nintendo EPD",
                Publisher = "Nintendo"
            },
            new VideoGame
            {
                Id = 6,
                Title = "Halo Infinite",
                Plataform = "Xbox Series X/S",
                Developer = "343 Industries",
                Publisher = "Xbox Game Studios"
            },
            new VideoGame
            {
                Id = 7,
                Title = "Spider-Man 2",
                Plataform = "PlayStation 5",
                Developer = "Insomniac Games",
                Publisher = "Sony Interactive Entertainment"
            },
            new VideoGame
            {
                Id = 8,
                Title = "The Witcher 3: Wild Hunt",
                Plataform = "PC",
                Developer = "CD Projekt Red",
                Publisher = "CD Projekt"
            },
            new VideoGame
            {
                Id = 9,
                Title = "Minecraft",
                Plataform = "Multi-platform",
                Developer = "Mojang Studios",
                Publisher = "Microsoft Studios"
            },
            new VideoGame
            {
                Id = 10,
                Title = "Fortnite",
                Plataform = "Multi-platform",
                Developer = "Epic Games",
                Publisher = "Epic Games"
            }
        };

        [HttpGet]
        public ActionResult<List<VideoGame>> GetVideoGames()
        {
            return Ok(videoGames);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<VideoGame> GetVideoGameById(int id)
        {
            var game = videoGames.FirstOrDefault(g => g.Id == id);
            if (game is null)
            {
                return NotFound();
            }

            return Ok(game);
        }

        [HttpPost]
        public ActionResult<VideoGame> AddVideoGame(VideoGame newGame)
        {
            if (newGame is null)
            {
                return BadRequest();
            }

            newGame.Id = videoGames.Max(g => g.Id) + 1;
            videoGames.Add(newGame);
            return CreatedAtAction(nameof(GetVideoGameById), new { id = newGame.Id }, newGame);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVideoGame(int id, VideoGame updatedGame)
        {
            var game = videoGames.FirstOrDefault(g => g.Id == id);
            if (game is null)
            {
                return NotFound();

            }

            game.Title = updatedGame.Title;
            game.Plataform = updatedGame.Plataform;
            game.Developer = updatedGame.Developer;
            game.Publisher = updatedGame.Publisher;

            return NoContent();

        }
    }
}
