public class GroupedRevenue{
    public string ArticleNumber { get; set; }
    public int Revenue { get; set; }
    
    // Default Construction
    public GroupedRevenue(string _articlenumber, int _revenue)
    {
         ArticleNumber = _articlenumber;
         Revenue = _revenue;
    }
}