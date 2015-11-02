using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToCS
{
    class ReadWrite
    {
        private string fileName1;
        private string fileName2;
        string[] splitter = { " , " };
        private ArrayList lines1 = new ArrayList();
        private ArrayList lines2 = new ArrayList();
        public ReadWrite(string txtFile1, string txtFile2)
        {
            this.fileName1 = txtFile1;
            this.fileName2 = txtFile2;
        }

        public Boolean ReadFiles()
        {
            string line;
            try
            {
                using (StreamReader file = new StreamReader(fileName1))
                {
                    while((line = file.ReadLine()) != null){
                        lines1.Add (line.Split(splitter, StringSplitOptions.RemoveEmptyEntries));
                    }
                }
            }
        }
    }
}
