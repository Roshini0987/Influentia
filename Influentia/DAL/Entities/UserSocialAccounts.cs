using System.ComponentModel.DataAnnotations;

namespace Influentia.DAL.Entities
{
    public class UserSocialAccounts
    {

        [MaxLength(10)]
        public int Id { get; set; }

        [MaxLength(10)]
        public int SocialAccountTypeId { get; set; }

        [StringLength(100)]
        public string LoginId { get; set; }

        [StringLength(100)]
        public string EncryptedPassword { get; set; }

        [StringLength(10)]
        public string UserName { get; set; }

        [StringLength(25)]
        public string SubscriptionName { get; set; }
    }
}
