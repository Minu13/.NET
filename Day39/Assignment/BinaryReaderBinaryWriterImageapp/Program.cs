using BinaryReaderBinaryWriterImageapp.Models;

namespace BinaryReaderBinaryWriterImageapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imagePath = "C:\\temp\\OIP.jpg";
            string outputPath = "C:\\temp\\output_image_half.jpg";


            ImageReader imageReader = new ImageReader();
            ImageProcessor imageProcessor = new ImageProcessor();
            ImageWriter imageWriter = new ImageWriter();

            byte[] imageBytes = imageReader.ReadImage(imagePath);

            byte[] halfImageBytes = imageProcessor.GetHalfByteArray(imageBytes);

            imageWriter.WriteImage(outputPath, halfImageBytes);

            Console.WriteLine("Image processing complete. Half of the image bytes written to: " + outputPath);

        }
    }
}
