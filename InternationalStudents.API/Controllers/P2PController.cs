using Microsoft.AspNetCore.Mvc;
using InternationalStudents.API.Models;
using InternationalStudents.API.DTOs;
using InternationalStudents.API.Services;

namespace InternationalStudents.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class P2PController : ControllerBase
    {
        private readonly IFirebaseService _firebaseService;
        private const string CollectionName = "p2p";

        public P2PController(IFirebaseService firebaseService)
        {
            _firebaseService = firebaseService;
        }

        [HttpGet]
        public async Task<ActionResult<List<P2PItem>>> GetP2PItems()
        {
            try
            {
                var items = await _firebaseService.GetDocumentsAsync<P2PItem>(CollectionName);
                return Ok(items);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error retrieving P2P items: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateP2PItem(CreateP2PItemDto dto)
        {
            try
            {
                var item = new P2PItem
                {
                    Title = dto.Title,
                    Description = dto.Description,
                    Price = dto.Price,
                    Category = dto.Category,
                    Condition = dto.Condition,
                    Images = dto.Images,
                    ContactInfo = dto.ContactInfo,
                    UserId = "current-user-id",
                    CreatedAt = DateTime.UtcNow,
                    Available = true
                };

                var id = await _firebaseService.CreateDocumentAsync(CollectionName, item);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error creating P2P item: {ex.Message}");
            }
        }
    }
}