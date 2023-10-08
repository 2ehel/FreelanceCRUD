using System.ComponentModel.DataAnnotations;

namespace Registry_API
{
    public class Talent
    {

        [Key]
        public int Id
        { get; set; }

        [StringLength(100)]
        public string Username { get; set; } = "";

        [StringLength(100)]
        public string Email { get; set; } = "";

        [StringLength(100)]
        public string PhoneNumbers { get; set; } = "";

        [StringLength(100)]
        public string Skillsets { get; set; } = "";

        [StringLength(100)]
        public string Hobby { get; set; } = "";
    }
}
