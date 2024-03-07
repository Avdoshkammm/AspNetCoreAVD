using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Contact
    {
        [Display(Name = "Введите имя")]
        public string Name { get; set; }
        [Display(Name = "Введите фамилию")]
        public string Surname { get; set; }
        [Display(Name = "Введите возраст")]
        public int Age { get; set; }
        [Display(Name = "Введите почту")]
        public string Email { get; set; }
        [Display(Name = "Введите сообщение")]
        public string Message { get; set; }
    }
}
