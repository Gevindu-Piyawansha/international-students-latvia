using Microsoft.AspNetCore.Mvc;
using InternationalStudents.API.Models;
using InternationalStudents.API.DTOs;
using InternationalStudents.API.Services;

namespace InternationalStudents.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly IFirebaseService _firebaseService;
        private const string CollectionName = "cars";

        public CarsController(IFirebaseService firebaseService)
        {
            _firebaseService = firebaseService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Car>>> GetCars()
        {
            try
            {
                var cars = await _firebaseService.GetDocumentsAsync<Car>(CollectionName);
                return Ok(cars);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error retrieving cars: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateCar(CreateCarDto dto)
        {
            try
            {
                var car = new Car
                {
                    Make = dto.Make,
                    Model = dto.Model,
                    Year = dto.Year,
                    Price = dto.Price,
                    Description = dto.Description,
                    Images = dto.Images,
                    ContactInfo = dto.ContactInfo,
                    UserId = "current-user-id",
                    CreatedAt = DateTime.UtcNow,
                    Available = true
                };

                var id = await _firebaseService.CreateDocumentAsync(CollectionName, car);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error creating car: {ex.Message}");
            }
        }
    }
}