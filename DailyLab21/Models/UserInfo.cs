using System.ComponentModel.DataAnnotations;

namespace DailyLab21.Models
{
    public class UserInfo
    {
        //Properties
        [Required] //Attributes
        [RegularExpression(@"^[a-zA-Z]{2,30}$")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]{2,30}$")]
        public string LastName { set; get; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        public string PhoneNumber { set; get; }

        [Required]
        [RegularExpression(@"^[a-zA-Z\d.]{5,20}@[a-zA-Z]{2,10}.[a-zA-Z]{1,3}$")]
        public string Email { set; get; }





        //Constructors
        public UserInfo()
        {
            FirstName = "";
            LastName = "";
            PhoneNumber = "";
            Email = "";
        }

        public UserInfo(string fn, string ln, string phone, string email)
        {
            FirstName = fn;
            LastName = ln;
            PhoneNumber = phone;
            Email = email;
        }



    }
}