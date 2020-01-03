public class TotalDailyRevenue{
    public string Day { get; set; }
    public double Revenue { get; set; }
    
    // Default Construction
    public TotalDailyRevenue(string _day, double _revenue)
    {
         Day = _day;
         Revenue = _revenue;
    }
}