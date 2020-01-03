public class GroupedRevenue{
    public string ArticleNumber { get; set; }
    public double Revenue { get; set; }
    
    // Default Construction
    public GroupedRevenue(string _articlenumber, double _revenue)
    {
         ArticleNumber = _articlenumber;
         Revenue = _revenue;
    }
}