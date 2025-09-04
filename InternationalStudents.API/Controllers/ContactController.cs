using Microsoft.AspNetCore.Mvc;
using InternationalStudents.API.Models;
using InternationalStudents.API.DTOs;
using InternationalStudents.API.Services;

namespace InternationalStudents.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IFirebaseService _firebaseService;
        private const string CollectionName = "contact";

        public ContactController(IFirebaseService firebaseService)
        {
            _firebaseService = firebaseService;
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateContactMessage(CreateContactMessageDto dto)
        {
            try
            {
                var message = new ContactMessage
                {
                    Name = dto.Name,
                    Email = dto.Email,
                    Subject = dto.Subject,
                    Message = dto.Message,
                    CreatedAt = DateTime.UtcNow
                };

                var id = await _firebaseService.CreateDocumentAsync(CollectionName, message);
                return Ok(new { message = "Message sent successfully", id });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error sending message: {ex.Message}");
            }
        }
    }
}