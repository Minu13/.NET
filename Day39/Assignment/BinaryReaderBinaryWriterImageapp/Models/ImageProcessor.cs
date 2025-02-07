using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryReaderBinaryWriterImageapp.Models
{
    public class ImageProcessor
    {
        public byte[] GetHalfByteArray(byte[] imageBytes)
        {
            int halfLength = imageBytes.Length / 2;
            MemoryStream ms = new MemoryStream(imageBytes);
            BinaryReader br = new BinaryReader(ms);
            byte[] halfArray = br.ReadBytes(halfLength);
            br.Close();
            ms.Close();
            return halfArray;
        }
    }

}
