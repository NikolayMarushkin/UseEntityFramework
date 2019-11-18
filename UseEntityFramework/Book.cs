
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UseEntityFramework
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Writer_Id { get; set; }
        public virtual ICollection<Writer> Writers { get; set; }
    }
}
