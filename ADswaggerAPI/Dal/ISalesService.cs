using System.Collections.Generic;
public interface ISalesService
{
    List<Sales> GetAllSales();
    
    void AddSale(Sales sales);

    List<TotalDailyRevenue> GetTotalDailyRevenue();
    List<DailySales> GetDailySalesCount();
    List<GroupedRevenue> GetGroupedRevenue();
}