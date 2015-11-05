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
        private readonly string skritukas = " , ";
        private string fileName1;
        private string fileName2;
        private StreamReader sarasas1, sarasas2;
        private StreamWriter list1, list2;
        private List<string[]> eilutes1 = new List<string[]>();
        private List<string[]> eilutes2 = new List<string[]>();

        public ReadWrite(string fileName1, string fileName2)
        {
            this.fileName1 = fileName1;
            this.fileName2 = fileName2;
        }

        public bool ReadFiles()
        {
            string line;
            try
            {
                sarasas1 = new StreamReader(fileName1);
                while((line = sarasas1.ReadLine()) != null)
                {
                    eilutes1.Add(line.Split(new string[] { " , " }, StringSplitOptions.None));
                }
                sarasas1.Close();

                sarasas2 = new StreamReader(fileName2);
                while ((line = sarasas2.ReadLine()) != null)
                {
                    eilutes2.Add(line.Split(new string[] { " , " }, StringSplitOptions.None));
                }
                sarasas2.Close();
            }
            catch (Exception e)
            {
                return false;
            }

            try
            {
                if (!File.Exists(fileName1))
                {
                    File.Create(fileName1);
                }
                list1 = new StreamWriter(fileName1);

                if (!File.Exists(fileName2))
                {
                    File.Create(fileName2);
                }
                list2 = new StreamWriter(fileName2);
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<string[]> GetText(int failas)
        {
            if (failas == 1)
            {
                return eilutes1;
            }
            else if (failas == 2)
            {
                return eilutes2;
            }
            else
            {
                return null;
            }
        }

        public void WriteToFile(int failas, string eile)
        {
            try
            {
                if (failas == 1)
                {
                    list1.Write(eile);
                } else if (failas == 2)
                {
                    list2.Write(eile);
                }
            }
            catch (Exception e)
            {

            }
        }

        public void CloseFiles()
        {
            try
            {
                list1.Flush();
                list2.Flush();
                list1.Close();
                list2.Close();
            }
            catch (Exception e)
            {

            }
        }
    }
}
