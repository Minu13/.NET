using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryReaderBinaryWriterImageapp.Models
{   
        public class ImageWriter
        {
            public void WriteImage(string outputPath, byte[] imageBytes)
            {
                FileStream fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(imageBytes);
                bw.Close();
                fs.Close();
            }
        }

    }

