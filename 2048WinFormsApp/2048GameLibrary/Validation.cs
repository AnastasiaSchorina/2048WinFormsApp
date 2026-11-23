
namespace _2048GameLibrary
{
    public class Validation
    {
        public static bool IsValidUserName(string name)
        {
            bool isGetNameUser = false;

            if (name == string.Empty || name.Length <= 1)
                throw new ArgumentException("Имя должно состоять как минимум из 2 букв.");

            foreach (char item in name)
            {
                if (!char.IsLetter(item))
                    throw new ArgumentException("Имя должно состоять только букв.");
            }
            return true;
        }
    }
}
