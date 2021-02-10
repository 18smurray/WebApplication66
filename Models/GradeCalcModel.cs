using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication66.Models
{
    //Property for each input of the form
    public class GradeCalcModel
    {
        //Each field is required and must be a number between 0 and 100
        [Required]
        [Range(0, 100)]
        public int Assignment { get; set; }
        
        [Required]
        [Range(0, 100)]
        public string Group { get; set; }

        [Required]
        [Range(0, 100)]
        public int Quiz { get; set; }

        [Required]
        [Range(0, 100)]
        public int Exam { get; set; }

        [Required]
        [Range(0, 100)]
        public int Intex { get; set; }
    }
}
