using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseEntityFramework
{
    public class MyDBContext : DbContext
    {
        // Строка подключения
        public MyDBContext() : base("DbConnectionString")
        {

        }

        public DbSet<Writer> Writers { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
