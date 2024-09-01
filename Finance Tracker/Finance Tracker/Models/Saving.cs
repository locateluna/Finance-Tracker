using System.ComponentModel.DataAnnotations.Schema;

namespace Finance_Tracker.Models
{
    [NotMapped]
    public class Saving : Account
    {
        public float InterestRate { get; set; }

    }
}
