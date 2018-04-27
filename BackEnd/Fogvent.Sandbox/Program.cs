using System;
using System.Text;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace Fogvent.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // namespace for the EdmxWriter class
            //var ctx = new Data.EF.AppContext(null);
            var optionsBuilder = new DbContextOptionsBuilder<Data.EF.AppContext>();
            optionsBuilder.UseSqlServer("test");

            using (var myContext = new Data.EF.AppContext(optionsBuilder.Options))
            {
                System.IO.File.WriteAllText(System.IO.Path.GetTempFileName() + ".dgml",
                    myContext.AsDgml(), Encoding.UTF8);
                Console.WriteLine(System.IO.Path.GetTempFileName());
            }

            Console.ReadLine();
        }
    }
}
