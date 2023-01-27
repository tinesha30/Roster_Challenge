using Backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class ArtistsController : ControllerBase
{
    private readonly RosterSynopsisDbContext _db;
       
    
    private readonly ILogger<ArtistsController> _logger;

    public ArtistsController(ILogger<ArtistsController> logger,RosterSynopsisDbContext db)
    {
        _db = db;
        _logger = logger;
    }

    [HttpGet(Name = "GetArtists")]
    public IEnumerable<Artist> Get()
    {
        //return Artists from DB otherwise return empty list
        return _db.Artists.ToList() ?? new List<Artist>();
    }
}

