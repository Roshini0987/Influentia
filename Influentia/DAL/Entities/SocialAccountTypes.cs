using System.ComponentModel.DataAnnotations;

namespace Influentia.DAL.Entities
{
    public class SocialAccountTypes
    {
        [MaxLength(10)]
        public int Id { get; set; }

        [StringLength(25)]
        public string AccountType { get; set; }
    }
}
