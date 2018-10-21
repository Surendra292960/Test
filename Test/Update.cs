using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Update
    {
        static void Main(string[] args)
        {
            StringBuilder newFile = new StringBuilder();

            string temp = null;
            string userchoice = null;
            string replacetext = null;
            string update = null;

            Console.WriteLine("enter the id of student to update the record");

            userchoice = Console.ReadLine();

        
            String[] file = File.ReadAllLines(@"g:\\HELLOEVERYONE.txt");
            foreach (string line in file)
            {
                if (line.Contains(userchoice))
                {
                    Console.WriteLine("enter the data you want to replace");
                    replacetext = Console.ReadLine();

                    if (line.Contains(replacetext))
                    {
                        Console.WriteLine("enter the data you want to replace with");
                        update = Console.ReadLine();
                        temp = line.Replace(replacetext, update);
                     
                        newFile.Append(temp + "\r\n");
                        continue;
                    }
                    newFile.Append(line + "\r\n");
                }
                File.WriteAllText(@"g:\\HELLOEVERYONE.txt", newFile.ToString());
            }
        }
    }
}
