
using Microsoft.AspNetCore.Mvc;
using ParkFlow.Api.Models;

namespace ParkFlow.Api.Controllers;

[ApiController]
[Route("api/parking-spaces")]
public class ParkingSpacesController : ControllerBase
{
    private static readonly List<ParkingSpace> Spaces = new()
    {
        new ParkingSpace
        {
            Id = 1,
            Code = "A01",
            Type = "Regular",
            Status = "Available"
        },
        new ParkingSpace
        {
            Id = 2,
            Code = "A02",
            Type = "Regular",
            Status = "Occupied"
        },
        new ParkingSpace
        {
            Id = 3,
            Code = "M01",
            Type = "Motorcycle",
            Status = "Available"
        }
    };


    [HttpGet]
    public ActionResult<List<ParkingSpace>> GetAll()
    {
        return Ok(Spaces);
    }

    [HttpGet("{id}")]
    public ActionResult<ParkingSpace> Get(int id)
    {
        var space = Spaces.FirstOrDefault(s => s.Id == id);
        if (space == null)
        {
            return NotFound();
        }
        return Ok(space);
    }
}
