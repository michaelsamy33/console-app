using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Students = new string[] { "ahlam", "ali", "mohmed", "kirollous", "sara", "mariam", "hosnya", "magdy" };

            var Result = from student in Students
                         orderby student descending
                         select student;


            foreach (var s in Result)
            {

                Console.WriteLine(s);
            }



        }
    }
}
