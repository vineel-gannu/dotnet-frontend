using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstAPI.Model
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
