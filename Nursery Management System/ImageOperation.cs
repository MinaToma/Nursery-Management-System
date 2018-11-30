using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
namespace Nursery_Management_System
{
    class ImageOperation
    {
        public  string ImageToString(Image image)
        {
            if (image == null)
                return String.Empty;

            var stream = new MemoryStream();
            image.Save(stream, image.RawFormat);
            var bytes = stream.ToArray();

            return Convert.ToBase64String(bytes);
        }

        public  Image StringToImage(string base64String)
        {
            if (String.IsNullOrWhiteSpace(base64String))
                return null;

            var bytes = Convert.FromBase64String(base64String);
            var stream = new MemoryStream(bytes);
            return Image.FromStream(stream);
        }



    }
}
