using System.ComponentModel.DataAnnotations;

namespace lab2.Models
{


    public class FormModel
    {
        [Display(Name = "Nazwa elementu")]
        public string Name { get; set; }

        [Display(Name = "how many times")]
        public int how_many_times { get; set; }


    }
}