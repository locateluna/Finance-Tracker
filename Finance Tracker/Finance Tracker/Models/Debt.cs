namespace Finance_Tracker.Models
{
    public class Debt : Saving
    {
        public required DateTime DueDate { get; set; }
        public float MinPayment { get; set; }
    }
}
