public class DailySales{
    public string Day { get; set; }
    public int Count { get; set; }
    
    // Default Construction
    public DailySales(string _day, int _count)
    {
         Day = _day;
         Count = _count;
    }
}