using System.ComponentModel.DataAnnotations;

namespace Influentia.DAL.Entities
{
    public class SocialAccountTracker
    {
        [MaxLength(10)]
        public int Id { get; set; }

        [MaxLength(10)]
        public int AccountId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [StringLength(25)]
        public string Action { get; set; }
    }
}
