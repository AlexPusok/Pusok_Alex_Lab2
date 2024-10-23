using System.ComponentModel.DataAnnotations;

namespace Pusok_Alex_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        public string fullName
        {
            get
            {
                return $"{firstName} {lastName}";
            }
        }
    }
}
