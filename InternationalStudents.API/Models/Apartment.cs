using Google.Cloud.Firestore;

namespace InternationalStudents.API.Models
{
    [FirestoreData]
    public class Apartment
    {
        [FirestoreProperty]
        public string Id { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string Title { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string Description { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public decimal Price { get; set; }
        
        [FirestoreProperty]
        public string Location { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public List<string> Images { get; set; } = new();
        
        [FirestoreProperty]
        public string ContactInfo { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string UserId { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public DateTime CreatedAt { get; set; }
        
        [FirestoreProperty]
        public bool Available { get; set; } = true;
    }

    [FirestoreData]
    public class Car
    {
        [FirestoreProperty]
        public string Id { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string Make { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string Model { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public int Year { get; set; }
        
        [FirestoreProperty]
        public decimal Price { get; set; }
        
        [FirestoreProperty]
        public string Description { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public List<string> Images { get; set; } = new();
        
        [FirestoreProperty]
        public string ContactInfo { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string UserId { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public DateTime CreatedAt { get; set; }
        
        [FirestoreProperty]
        public bool Available { get; set; } = true;
    }

    [FirestoreData]
    public class Food
    {
        [FirestoreProperty]
        public string Id { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string Name { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string Description { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public decimal Price { get; set; }
        
        [FirestoreProperty]
        public string Category { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public List<string> Images { get; set; } = new();
        
        [FirestoreProperty]
        public string ContactInfo { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string UserId { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public bool Available { get; set; } = true;
        
        [FirestoreProperty]
        public DateTime CreatedAt { get; set; }
    }

    [FirestoreData]
    public class P2PItem
    {
        [FirestoreProperty]
        public string Id { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string Title { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string Description { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public decimal Price { get; set; }
        
        [FirestoreProperty]
        public string Category { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string Condition { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public List<string> Images { get; set; } = new();
        
        [FirestoreProperty]
        public string ContactInfo { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string UserId { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public bool Available { get; set; } = true;
        
        [FirestoreProperty]
        public DateTime CreatedAt { get; set; }
    }

    [FirestoreData]
    public class ContactMessage
    {
        [FirestoreProperty]
        public string Id { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string Name { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string Email { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string Subject { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public string Message { get; set; } = string.Empty;
        
        [FirestoreProperty]
        public DateTime CreatedAt { get; set; }
    }
}