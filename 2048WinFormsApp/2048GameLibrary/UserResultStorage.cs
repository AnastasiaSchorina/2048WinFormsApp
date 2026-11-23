using _2048WinFormsApp;
using Newtonsoft.Json;

namespace _2048GameLibrary{

    public class UserResultStorage
    {
        private static string path = "result2048.json";

        public static void Save(User user)
        {
            var usersResult = GetAll();
            usersResult.Add(user);
            var jsonData = JsonConvert.SerializeObject(usersResult, Formatting.Indented);
            FileManager.OverWrite(path, jsonData);
        }

        public static List<User> GetAll()
        {
            if (!FileManager.Exist(path))
            {
                return new List<User>();
            }
            var fileData = FileManager.Read(path);
            var jsonData = JsonConvert.DeserializeObject<List<User>>(fileData);
            return jsonData;
        }

        public static User GetMaxScore(List<User> users)
        {
            var maxScore = 0;
            if (users.Count > 1)
            {
                foreach (var item in users)
                    maxScore = Math.Max(maxScore, item.Score);

                foreach (var item in users)
                {
                    if (item.Score == maxScore)
                        return item;
                }
            }
            return users[0];
        }      
    }
}
