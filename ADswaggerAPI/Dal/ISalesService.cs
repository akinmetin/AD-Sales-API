using System.Collections.Generic;
public interface ISalesService
{
    List<Sales> GetAllSales();
    // Sales GetSalesByID(int id);
    // Sales GetSalesByArticleNumber(string ArticleNumber);
    
    void AddSale(Sales sales);

    List<TotalDailyRevenue> GetTotalDailyRevenue();
    List<DailySales> GetDailySalesCount();
    List<GroupedRevenue> GetGroupedRevenue();
}