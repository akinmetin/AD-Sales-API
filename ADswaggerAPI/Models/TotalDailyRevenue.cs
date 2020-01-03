public class TotalDailyRevenue{
    public string Day { get; set; }
    public int Revenue { get; set; }
    
    // Default Construction
    public TotalDailyRevenue(string _day, int _revenue)
    {
         Day = _day;
         Revenue = _revenue;
    }
}