using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

public class SalesService : ISalesService
{
    // Example pre-defined data
    public static List<Sales> salesList = new List<Sales>(){
        new Sales(){ArticleNumber="1AVFX4", SalesPrice=8, Day="Tue"},
        new Sales(){ArticleNumber="5GBH631A", SalesPrice=14, Day="Sun"},
        new Sales(){ArticleNumber="1AVFX4", SalesPrice=8, Day="Mon"},
        new Sales(){ArticleNumber="5GBH631A", SalesPrice=14, Day="Tue"},
    };
    public static List<TotalDailyRevenue> totalDailyRevenueList = new List<TotalDailyRevenue>();
    public static List<DailySales> dailySalesList = new List<DailySales>();
    public static List<GroupedRevenue> groupedRevenueList = new List<GroupedRevenue>();

    // Return pre-defined salesList
    public List<Sales> GetAllSales()
    {
        return salesList;
    }

    // Add element into salesList
    public void AddSale(Sales sales)
    {
        salesList.Add(sales);
    }

    // Sum up the total revenues and group them by day
    public List<TotalDailyRevenue> GetTotalDailyRevenue(){
        var salesListGroupedByArticles = salesList.GroupBy(salesList => salesList.Day);
        double total = 0;
        foreach(var group in salesListGroupedByArticles)    
        {
        Console.WriteLine("Revenue on " + group.Key + ":");    
        foreach(var article in group)
            total = total + article.SalesPrice;
        Console.WriteLine(total);
        TotalDailyRevenue temp_list = new TotalDailyRevenue(group.Key, total);
        totalDailyRevenueList.Add(temp_list);
        total = 0;
        }
        return totalDailyRevenueList;
    }

    // Group the articles by day and count
    public List<DailySales> GetDailySalesCount(){
        var salesListGroupedByArticles = salesList.GroupBy(salesList => salesList.Day);    
        foreach(var group in salesListGroupedByArticles)    
        {
        Console.WriteLine("Number of sold articles on " + group.Key + ":");    
        Console.WriteLine(group.Count());

        DailySales temp_list = new DailySales(group.Key, group.Count());
        dailySalesList.Add(temp_list);
        }
        return dailySalesList;
    }

    // Group the articles by article number and sum up the revenues
    public List<GroupedRevenue> GetGroupedRevenue(){
        var salesListGroupedByArticles = salesList.GroupBy(salesList => salesList.ArticleNumber);   
        double total = 0;
        foreach(var group in salesListGroupedByArticles)    
        {
        Console.WriteLine("Revenue from article " + group.Key + ":");    
        foreach(var article in group)
            total = total + article.SalesPrice;
        Console.WriteLine("Revenue: " + total);
        GroupedRevenue temp_list = new GroupedRevenue(group.Key, total);
        groupedRevenueList.Add(temp_list);
        total = 0;
        }
        return groupedRevenueList;
    }
}

// c# groupby --> https://csharp.net-tutorials.com/linq/grouping-data-the-groupby-method/
// c# append tuple to list --> https://stackoverflow.com/questions/42785492/adding-an-item-to-a-tuple-in-c-sharp
// c# add tuples into list --> https://stackoverflow.com/questions/23779824/c-sharp-adding-to-list-of-tuples-with-a-function