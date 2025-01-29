using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterFileStreamApp.Models
{
    class FileWriter
    {
        private StreamWriter _writer;

        public FileWriter(string filePath)
        {
            _writer = new StreamWriter(filePath);
        }

        public void WriteToFile(string username, string address)
        {
            _writer.WriteLine("UserName:" + username);
            _writer.WriteLine("Address:" + address);
        }

        public void Close()
        {
            _writer.Close();
        }
    }
}
