using System.ComponentModel.DataAnnotations;

namespace B05ASPC06_w01.Models
{
    public class Client
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(15)]
        public string Contact { get; set; }
        
        public string Address { get; set; }

    }
}