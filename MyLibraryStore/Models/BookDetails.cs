using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Models
{
    public class BookDetails
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Book Name")]
        public string BookName { get; set; }

        [Required]
        [Display(Name ="Author Name")]
        public string Author { get; set; }

        [Required]
        [Display(Name ="ISBook No")]
        public string ISBN { get; set; }

        [Display(Name = "Genre Type")]
        public string Genre { get; set; }


        [Display(Name ="Published Date")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
    }
}
