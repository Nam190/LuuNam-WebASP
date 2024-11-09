using System.ComponentModel.DataAnnotations;

namespace WebHangHoa.DTO
{
    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }


        [Required]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    
    }
}
