namespace Finance_Tracker.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required float Value { get; set; }
        public int Type {  get; set; }
    }
}
