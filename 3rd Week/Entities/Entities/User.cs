using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdWeekModel.Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required, StringLength(20)]
        public string Name { get; set; }
        [Required, StringLength(20)]
        public string Surname { get; set; }
        [Required, StringLength(30)]
        public string Email { get; set; }
        [Required, StringLength(30)]
        public string Password { get; set; }
        [Required, StringLength(15)]
        public string Phone { get; set; }
        [Required, StringLength(50)]
        public string Adress { get; set; }

        public List<Product> Products { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
