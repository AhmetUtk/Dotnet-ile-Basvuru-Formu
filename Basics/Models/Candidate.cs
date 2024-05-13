using System.ComponentModel.DataAnnotations;
namespace Basics.Models

{
    public class Candidate
    {

        [Required(ErrorMessage = "Email alanı doldurulmalıdır")]
        public String? Email {get;set;} = String.Empty;
        [Required(ErrorMessage = "İsim alanı doldurulmalıdır")]
        public String? Firstname {get;set;} = String.Empty;
        [Required(ErrorMessage = "Soyisim alanı doldurulmalıdır")]
        public String? Lastname {get;set;} = String.Empty;

        public String? FullName => $"{Firstname} {Lastname?.ToUpper()}";
        [Required(ErrorMessage = "Yaş alanı doldurulmalıdır")]
        public int? Age {get;set;}
        [Required(ErrorMessage = "Kurs seçimi yapın")]
        public String? SelectedCourse {get;set;} = String.Empty;
        public DateTime ApplyAt {get;set;}

        public Candidate(){
            ApplyAt = DateTime.Now;
        }
    }

    
}