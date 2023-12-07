using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class News
    {
        public News() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title {  get; set; }
        public string Description { get; set; }
        public DateTime DateUpdate { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
    }
}
