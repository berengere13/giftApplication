using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Xamarin.Auth;
using Newtonsoft.Json;
using User = GiftApp.Models.User;

namespace GiftApp.Services
{
    public class DataBaseService
    {
        private FirebaseClient FirebaseClient;

        public FirebaseClient GetFirebaseClient()
        {
            if (FirebaseClient == null)
            {
                //FirebaseClient = new FirebaseClient(FirebaseURL, new FirebaseOptions
                //{
                //    AuthTokenAsyncFactory = () => Task.FromResult(FirebaseKey)
                //});

                var opt = new FirebaseOptions
                {
                    JsonSerializerSettings = new JsonSerializerSettings
                    {

                    }
                };
                FirebaseClient = new FirebaseClient(FirebaseURL);
            }

            return FirebaseClient;
        }

        public async Task<List<User>> GetUsersFromDataBase()
        {
            var listUsers = new List<User>();

            var users = await GetFirebaseClient().Child("users").OrderByKey().OnceAsync<User>();

            foreach (var firebaseUser in users)
            {
                listUsers.Add(new User(firebaseUser.Object));
            }

            return listUsers;
        }
    }
}
