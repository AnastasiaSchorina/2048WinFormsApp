using System.Drawing;

namespace _2048GameLibrary
{
    public class ColorsStorage
    {
        public static Dictionary<string, Color> GetAll()
        {
            Dictionary<string, Color> colorsLabel = new Dictionary<string, Color>
            {
                [""] = SystemColors.ActiveCaption,
                ["2"] = SystemColors.ActiveCaption,
                ["4"] = Color.Azure,
                ["8"] = Color.Beige,
                ["16"] = Color.Bisque,
                ["32"] = Color.Blue,
                ["64"] = Color.BurlyWood,
                ["128"] = Color.Coral,
                ["256"] = Color.CornflowerBlue,
                ["512"] = Color.DarkCyan,
                ["1024"] = Color.DarkOrange,
            };
            return colorsLabel;
        }

        public static Color AssignColor(string number)
        {
            var colorsLabel = GetAll();
            return colorsLabel[number];
        }
    }
}
