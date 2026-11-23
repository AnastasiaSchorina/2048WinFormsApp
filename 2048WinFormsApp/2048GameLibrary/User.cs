namespace _2048GameLibrary
{
    public class User
    {
        public string Name { get; set; }
        public int Score { get; set; }


        public User(string name)
        {
            Name = name;
            Score = 0;
        }
    }
}
