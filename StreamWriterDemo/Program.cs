using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var sw = new StreamWriter(@"c:\\vidobu\\days.txt"))
            {

                foreach (var day in Enum.GetNames(typeof(DayOfWeek)))
                {
                    sw.WriteLine(day);
                }

                sw.Flush();
                sw.Close();
            }

            Console.ReadKey();
        }
    }
}
