

using System.ComponentModel.DataAnnotations;

namespace UseEntityFramework
{
    public class Writer
    {

        // Key Wr
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Book Book { get; set; }
    }
}
