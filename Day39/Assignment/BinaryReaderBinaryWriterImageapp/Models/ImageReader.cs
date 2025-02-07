using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryReaderBinaryWriterImageapp.Models
{
    public class ImageReader
    {
        public byte[] ReadImage(string imagePath)
        {
            FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            byte[] imageBytes = new byte[fs.Length];
            fs.Read(imageBytes, 0, imageBytes.Length);
            fs.Close();
            return imageBytes;
        }
    }

}
