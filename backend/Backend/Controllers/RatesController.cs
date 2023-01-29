using System;
using Backend.Data;
using Backend.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class RatesController : ControllerBase
{
    private readonly RosterSynopsisDbContext _db;


    private readonly ILogger<ArtistsController> _logger;

    public RatesController(ILogger<ArtistsController> logger, RosterSynopsisDbContext db)
    {
        _db = db;
        _logger = logger;
    }

    [HttpGet(Name = "GetRates")]
    public IEnumerable<Rate> Get()
    {
        //return Rates from DB otherwise return empty list
        return _db.Rates.ToList() ?? new List<Rate>();
    }

    [HttpPost]
    public async Task<IActionResult> CreateRate(NewRateCommand newRate)
    {
        try
        {
            Rate rate = new Rate()
            {
                ArtistId = newRate.ArtistId,
                RateAmount = newRate.Amount
            };
            _db.Rates.Add(rate);

            await _db.SaveChangesAsync();

            return Ok(rate);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message ?? ex.InnerException?.Message,ex);
            return StatusCode(500);
        }


       
    }
}




