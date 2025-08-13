using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Resume.Domain.FormatLoaders
{
    public class ImageLoader
    {
        public Bitmap Load(string path)
        {
            try
            {
                Bitmap image = new Bitmap(path);
                return image;
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Bitmap empty = null; //later adding an image that says file not found, for now it'll be null.
                return empty;
            }
        }
    }
}
