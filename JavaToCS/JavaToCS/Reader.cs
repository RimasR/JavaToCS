using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCS
{
    public class Reader
    {
        private readonly string filePath;
        private StreamReader reader;

        public Reader(string filePath)
        {
            this.filePath = filePath;
        }

        public bool OpenFile()
        {
            try
            {
                reader = new StreamReader(filePath);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public void ReadLine()
        {
            reader.ReadLine();
        }

        public bool CloseFile()
        {
            try
            {
                reader.Close();
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }
    }
}
