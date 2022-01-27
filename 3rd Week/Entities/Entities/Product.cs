using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdWeekModel.Entities
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required, StringLength(30)]
        public string Title { get; set; }
        [Required, StringLength(200)]
        public string Description { get; set; }

        //Foreign Keys
        public int SellerID { get; set; }
        public Seller Seller { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
