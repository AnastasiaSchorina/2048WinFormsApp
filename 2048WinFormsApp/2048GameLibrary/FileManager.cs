
namespace _2048WinFormsApp
{
    public class FileManager
    {
        public static void OverWrite(string path, string data)
        {
            File.WriteAllText(path, data);
        }

        public static string Read(string path)
        {
            using StreamReader streamReader = new StreamReader(path);
            return streamReader.ReadToEnd();
        }

        public static bool Exist(string path)
        {
            return File.Exists(path);
        }      
    }
}
