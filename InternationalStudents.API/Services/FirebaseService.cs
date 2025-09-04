using Google.Cloud.Firestore;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

namespace InternationalStudents.API.Services
{
    public interface IFirebaseService
    {
        FirestoreDb GetFirestoreDb();
        Task<string> CreateDocumentAsync<T>(string collection, T document) where T : class;
        Task<List<T>> GetDocumentsAsync<T>(string collection) where T : class;
        Task<T?> GetDocumentAsync<T>(string collection, string documentId) where T : class;
        Task UpdateDocumentAsync<T>(string collection, string documentId, T document) where T : class;
        Task DeleteDocumentAsync(string collection, string documentId);
    }

    public class FirebaseService : IFirebaseService
    {
        private readonly FirestoreDb _firestoreDb;

        public FirebaseService(IConfiguration configuration)
        {
            var projectId = configuration["Firebase:ProjectId"];
            
            if (FirebaseApp.DefaultInstance == null)
            {
                FirebaseApp.Create(new AppOptions()
                {
                    ProjectId = projectId,
                    Credential = GoogleCredential.GetApplicationDefault()
                });
            }

            _firestoreDb = FirestoreDb.Create(projectId);
        }

        public FirestoreDb GetFirestoreDb() => _firestoreDb;

        public async Task<string> CreateDocumentAsync<T>(string collection, T document) where T : class
        {
            var docRef = await _firestoreDb.Collection(collection).AddAsync(document);
            return docRef.Id;
        }

        public async Task<List<T>> GetDocumentsAsync<T>(string collection) where T : class
        {
            var snapshot = await _firestoreDb.Collection(collection)
                .OrderByDescending("CreatedAt")
                .GetSnapshotAsync();
            
            var documents = new List<T>();
            foreach (var doc in snapshot.Documents)
            {
                if (doc.Exists)
                {
                    var data = doc.ConvertTo<T>();
                    // Set the Id property if it exists
                    var idProperty = typeof(T).GetProperty("Id");
                    idProperty?.SetValue(data, doc.Id);
                    documents.Add(data);
                }
            }
            return documents;
        }

        public async Task<T?> GetDocumentAsync<T>(string collection, string documentId) where T : class
        {
            var docRef = _firestoreDb.Collection(collection).Document(documentId);
            var snapshot = await docRef.GetSnapshotAsync();
            
            if (snapshot.Exists)
            {
                var data = snapshot.ConvertTo<T>();
                var idProperty = typeof(T).GetProperty("Id");
                idProperty?.SetValue(data, documentId);
                return data;
            }
            return null;
        }

        public async Task UpdateDocumentAsync<T>(string collection, string documentId, T document) where T : class
        {
            var docRef = _firestoreDb.Collection(collection).Document(documentId);
            await docRef.SetAsync(document, SetOptions.MergeAll);
        }

        public async Task DeleteDocumentAsync(string collection, string documentId)
        {
            var docRef = _firestoreDb.Collection(collection).Document(documentId);
            await docRef.DeleteAsync();
        }
    }
}