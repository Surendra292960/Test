using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Reader
    {
        public static void Main(string[] args)
        {

            try
            {

                FileStream f = new FileStream("g:\\HELLOEVERYONE.txt", FileMode.OpenOrCreate);
                StreamReader s = new StreamReader(f);

                string line = s.ReadLine();
                Console.WriteLine(line);

                s.Close();
                f.Close();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("FileNotFoundException" + ex);
            }
            Console.Read();
        }
    }
}
