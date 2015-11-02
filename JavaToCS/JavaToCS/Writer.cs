using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCS
{
    public class Writer
    {
        private readonly string filePath;
        private StreamWriter writer;

        public Writer(string filePath)
        {
            this.filePath = filePath;
        }

        public bool OpenFile()
        {
            try
            {
                writer = new StreamWriter(filePath);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public void WriteLine<T>(T line)
        {
            writer.WriteLine(line);
        }

        public bool CloseFile()
        {
            try
            {
                writer.Close();
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }
    }
}
