using Microsoft.AspNetCore.Mvc;
using InternationalStudents.API.Models;
using InternationalStudents.API.DTOs;
using InternationalStudents.API.Services;

namespace InternationalStudents.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApartmentsController : ControllerBase
    {
        private readonly IFirebaseService _firebaseService;
        private const string CollectionName = "apartments";

        public ApartmentsController(IFirebaseService firebaseService)
        {
            _firebaseService = firebaseService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Apartment>>> GetApartments()
        {
            try
            {
                var apartments = await _firebaseService.GetDocumentsAsync<Apartment>(CollectionName);
                return Ok(apartments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error retrieving apartments: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Apartment>> GetApartment(string id)
        {
            try
            {
                var apartment = await _firebaseService.GetDocumentAsync<Apartment>(CollectionName, id);
                if (apartment == null)
                {
                    return NotFound();
                }
                return Ok(apartment);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error retrieving apartment: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateApartment(CreateApartmentDto dto)
        {
            try
            {
                var apartment = new Apartment
                {
                    Title = dto.Title,
                    Description = dto.Description,
                    Price = dto.Price,
                    Location = dto.Location,
                    Images = dto.Images,
                    ContactInfo = dto.ContactInfo,
                    UserId = "current-user-id",
                    CreatedAt = DateTime.UtcNow,
                    Available = true
                };

                var id = await _firebaseService.CreateDocumentAsync(CollectionName, apartment);
                return CreatedAtAction(nameof(GetApartment), new { id }, id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error creating apartment: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApartment(string id, CreateApartmentDto dto)
        {
            try
            {
                var existingApartment = await _firebaseService.GetDocumentAsync<Apartment>(CollectionName, id);
                if (existingApartment == null)
                {
                    return NotFound();
                }

                existingApartment.Title = dto.Title;
                existingApartment.Description = dto.Description;
                existingApartment.Price = dto.Price;
                existingApartment.Location = dto.Location;
                existingApartment.Images = dto.Images;
                existingApartment.ContactInfo = dto.ContactInfo;

                await _firebaseService.UpdateDocumentAsync(CollectionName, id, existingApartment);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error updating apartment: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApartment(string id)
        {
            try
            {
                await _firebaseService.DeleteDocumentAsync(CollectionName, id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error deleting apartment: {ex.Message}");
            }
        }
    }
}