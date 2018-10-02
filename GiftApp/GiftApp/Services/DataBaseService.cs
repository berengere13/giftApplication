using GiftApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace GiftApp.Services
{
    public class DataBaseService
    {
        private FirebaseClient FirebaseClient;

        public FirebaseClient GetFirebaseClient()
        {
            if (FirebaseClient == null)
            {
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
