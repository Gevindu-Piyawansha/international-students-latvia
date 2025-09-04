namespace InternationalStudents.API.DTOs
{
    public class CreateApartmentDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Location { get; set; } = string.Empty;
        public List<string> Images { get; set; } = new();
        public string ContactInfo { get; set; } = string.Empty;
    }

    public class CreateCarDto
    {
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<string> Images { get; set; } = new();
        public string ContactInfo { get; set; } = string.Empty;
    }

    public class CreateFoodDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;
        public List<string> Images { get; set; } = new();
        public string ContactInfo { get; set; } = string.Empty;
    }

    public class CreateP2PItemDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Condition { get; set; } = string.Empty;
        public List<string> Images { get; set; } = new();
        public string ContactInfo { get; set; } = string.Empty;
    }

    public class CreateContactMessageDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
    }
}