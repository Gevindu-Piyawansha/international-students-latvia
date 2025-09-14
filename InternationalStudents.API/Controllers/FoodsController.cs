using Microsoft.AspNetCore.Mvc;
using InternationalStudents.API.Models;
using InternationalStudents.API.DTOs;
using InternationalStudents.API.Services;

namespace InternationalStudents.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodsController : ControllerBase
    {
        private readonly IFirebaseService _firebaseService;
        private const string CollectionName = "foods";

        public FoodsController(IFirebaseService firebaseService)
        {
            _firebaseService = firebaseService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Food>>> GetFoods()
        {
            try
            {
                var foods = await _firebaseService.GetDocumentsAsync<Food>(CollectionName);
                return Ok(foods);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error retrieving foods: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateFood(CreateFoodsDto dto)
        {
            try
            {
                var food = new Food
                {
                    Name = dto.Name,
                    Description = dto.Description,
                    Price = dto.Price,
                    Category = dto.Category,
                    Images = dto.Images,
                    ContactInfo = dto.ContactInfo,
                    UserId = "current-user-id",
                    CreatedAt = DateTime.UtcNow,
                    Available = true
                };

                var id = await _firebaseService.CreateDocumentAsync(CollectionName, food);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error creating food: {ex.Message}");
            }
        }
    }
}