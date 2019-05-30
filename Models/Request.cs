using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CreditCardApp.Models
{
    public class Request
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("First name")]
        [Required]
        public string firstName { get; set; }
        [DisplayName("Last name")]
        [Required]
        public string lastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DisplayName("Date of Birth")]
        public DateTime dob { get; set; }
        [Required]
        [DisplayName("Income")]
        public int income { get; set; }
        [DisplayName("Suggested solution")]
        public string solution { get; set; }
    }
}