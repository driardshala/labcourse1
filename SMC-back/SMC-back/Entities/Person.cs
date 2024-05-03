using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMC_back.Entities
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        [ForeignKey("Staff")]
        public int StaffID { get; set; }
        public Staff Staff { get; set; }
        
        
    }
}
