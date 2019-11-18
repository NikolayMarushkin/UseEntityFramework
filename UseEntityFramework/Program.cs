using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDBContext())
            {
                var writer = new Writer()
                {
                    Name = "А.С.Пушкин"
                };
                context.Writers.Add(writer);
                context.SaveChanges();

                Console.WriteLine($"id: {writer.Id} name: {writer.Name}");
                Console.ReadLine();
            }
        }
    }
}
